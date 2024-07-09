namespace Shop.Types.Products.Dtos;

public readonly record struct ProductSummaryDto(
    Guid Id,
    Guid BrandId,
    string Name,
    string BrandName,
    string Image,
    bool IsFeatured,
    bool IsInStock,
    decimal Price,
    decimal? SalePrice,
    decimal? ShippingPrice,
    DateTime? SaleEndDate,
    DateTime ReleaseDate,
    float Rating,
    int NumberRatings,
    decimal Weight,
    string Dimensions,
    int ShippingDays )
{
    public decimal RealPrice() =>
        SalePrice ?? Price;
}