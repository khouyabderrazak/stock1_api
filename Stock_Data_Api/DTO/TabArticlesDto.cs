namespace Stock_Data_Api.DTO;

public record TabArticlesDto
(
    int? Id,
    bool IsArticleVisible,
    bool IsQuantityVisible,
    bool IsPriceVisible,
    bool DoApplyTotalDiscount,
    bool ShowShippingCosts,
    bool IsTaxVisible,
    bool IsAmountVisible,
    bool IsDiscountVisible,
    int? ShippingCostsTaxId,
    decimal SubTotal,
    double TotalQuantity,
    double TotalDiscount,
    decimal ShippingCosts,
    decimal? OtherCostsAmount,
    string? OtherCostsLabel,
    string? InfoClient,
    decimal? Total,
    List<TabItem> TabRows
);

public record TabItem
(
    int Id,
    string Name,
    bool IsImplicit,
    string Desc,
    int? ArticleId,
    decimal Discount,
    double Quantity,
    decimal Price,
    int? TaxId
);