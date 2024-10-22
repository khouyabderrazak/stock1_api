using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Stock_Data_Api.Data;
using Stock_Data_Api.Models;
using Stock_Data_Api.Models.Dto;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stock_Data_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataDbContext _db;
        private readonly PasswordHasher<User> _passwordHasher;
        private const string JwtKey = "abderrazzakkhouyabderrazzakkhouyabderrazzakkhouyabderrazzakkhouyabderrazzakkhouy";

        public UserController(DataDbContext db)
        {
            _db = db;
            _passwordHasher = new PasswordHasher<User>();
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] UserDAO user)
        {
            if (user == null)
            {
                return BadRequest(new { Message = "Invalid user" });
            }

            var usr = await _db.Users.FirstOrDefaultAsync(x => x.username == user.username);

            if (usr == null || _passwordHasher.VerifyHashedPassword(usr, usr.password, user.password) == PasswordVerificationResult.Failed)
            {
                return NotFound(new { Message = "Username or password is incorrect" });
            }

            usr.Role = "User";
            usr.tocken = CreateJwtToken(usr);
            var newAccessToken = usr.tocken;
            var refreshToken = CreateRefreshToken();
            usr.RefreshToken = refreshToken;
            usr.RefreshTokenExperyTime = DateTime.Now.AddDays(12);

            _db.SaveChanges();

            return Ok(new
            {
                Token = new TokenApiDto
                {
                    AccessToken = newAccessToken,
                    RefreshToken = refreshToken
                },
                Message = "Login success!"
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest(new { Message = "Invalid data" });
            }

            if (await CheckUserEmail(user.email))
            {
                return BadRequest(new { Message = "Email already exists!" });
            }

            if (await CheckUserName(user.username))
            {
                return BadRequest(new { Message = "Username already exists!" });
            }

            var pass = CheckPasswordString(user.password);
            if (!string.IsNullOrEmpty(pass))
            {
                return BadRequest(new { Message =pass });
            }

            if (ModelState.IsValid)
            {
                user.Role = "User";
                user.password = _passwordHasher.HashPassword(user, user.password);

                await _db.Users.AddAsync(user);
                await _db.SaveChangesAsync();

                return Ok(new { Message = "User added with success" });
            }
            else
            {
                return BadRequest(new { Message = "Some data not valid" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _db.Users.ToListAsync());
        }

        [NonAction]
        private string CreateRefreshToken()
        {
            var tokenBytes = RandomNumberGenerator.GetBytes(64);
            var refreshToken = Convert.ToBase64String(tokenBytes);
            if (_db.Users.Any(u => u.RefreshToken == refreshToken))
            {
                return CreateRefreshToken();
            }
            return refreshToken;
        }

        [NonAction]
        private ClaimsPrincipal GetClaimsPrincipalFromExpiredToken(string token)
        {
            var key = Encoding.ASCII.GetBytes(JwtKey);
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateLifetime = false
            };

            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var principal = jwtTokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh(TokenApiDto tokenApiDto)
        {
            if (tokenApiDto == null)
                return BadRequest("Invalid client request");

            string accessToken = tokenApiDto.AccessToken;
            string refreshToken = tokenApiDto.RefreshToken;

            var principal = GetClaimsPrincipalFromExpiredToken(accessToken);
            var username = principal.Identity.Name;

            var user = await _db.Users.FirstOrDefaultAsync(u => u.username == username);
            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExperyTime <= DateTime.Now)
            {
                return BadRequest("Invalid request");
            }

            var newAccessToken = CreateJwtToken(user);
            var newRefreshToken = CreateRefreshToken();

            user.RefreshToken = newRefreshToken;

            _db.SaveChanges();

            return Ok(new TokenApiDto
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            });
        }

        [NonAction]
        public async Task<bool> CheckUserName(string username)
        {
            return await _db.Users.AnyAsync(p => p.username == username);
        }

        [NonAction]
        public async Task<bool> CheckUserEmail(string email)
        {
            return await _db.Users.AnyAsync(p => p.email == email);
        }

        [NonAction]
        public string CheckPasswordString(string password)
        {
            StringBuilder strb = new StringBuilder();
            if (password.Length < 6)
                strb.Append("- Password length must be greater than 6\n");
            if (!(Regex.IsMatch(password, "[a-z]") && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "[0-9]")))
            {
                strb.Append("- Password must contain alphanumeric characters\n");
            }
            if (!Regex.IsMatch(password, "['/@#$%*!']"))
            {
                strb.Append("- Password must contain special characters\n");
            }
            return strb.ToString();
        }

        [NonAction]
        private string CreateJwtToken(User user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(JwtKey);
            var identity = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.Name, user.username)
            });

            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.Now.AddDays(10),
                SigningCredentials = credentials
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);

            return jwtTokenHandler.WriteToken(token);
        }

        [HttpPost("isEmailAlreadyExist")]
        public async Task<Boolean> isEmailAlreadyExist([FromBody] string email)
        { 
            var user = await _db.Users.FirstOrDefaultAsync(u => u.email == email);

            if (user==null)
                return false;
            return true;
        }

    }
}
