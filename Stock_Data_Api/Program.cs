using Hangfire;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Stock_Data_Api.Data;
using System.Net.NetworkInformation;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});


builder.Services.AddHangfire(x => x.UseSqlServerStorage(@"Server=DESKTOP-5AEMSP8;Initial Catalog=hangedb;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddHangfireServer();


builder.Services.Configure<FormOptions>(p =>
{
    p.ValueLengthLimit = int.MaxValue;
    p.MultipartBoundaryLengthLimit = int.MaxValue;
    p.MemoryBufferThreshold = int.MaxValue;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(

    x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }
    ).AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("abderrazzakkhouyabderrazzakkhouyabderrazzakkhouy")),
            ValidateAudience = false,
            ValidateIssuer = false
        };
    });

var app = builder.Build();

app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:4200")
           .AllowAnyHeader()
           .AllowAnyMethod();
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Resources")),
    RequestPath = new PathString("/Resources")

}); ;

app.UseCors(
    x =>
     x.AllowAnyOrigin()
      .AllowAnyHeader()
      .AllowAnyMethod()
    );

app.UseHttpsRedirection();
app.UseHangfireDashboard();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();


