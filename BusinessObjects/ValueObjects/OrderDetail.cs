namespace DTOs.ValueObjects
{
    public record struct OrderDetail(int ProductId, decimal UnitPrice, short Quantity);
}
