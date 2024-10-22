namespace Stock_Data_Api.DTO;

public record InvoiceSellDto
(
    int? Id,
    int ClientId,
    string NInvoice,
    string NOrder,
    DateTime InvoiceDate,
    DateTime? DueDate,
    int? InvoiceSellGroupId,
    int PaymentCdtId,
    int? SellerId,
    string? Objet,
    string? GeneralConditions,
    TabArticlesDto TableArticles
);
