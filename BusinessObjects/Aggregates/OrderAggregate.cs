using DTOs.ValueObjects;

namespace DTOs.Aggregates
{
    public class OrderAggregate : Order
    {
        readonly List<OrderDetail> orderDetails = new();
        public IReadOnlyCollection<OrderDetail> OrderDetails => orderDetails;

        public void AddDetail(OrderDetail newOrderDetail)
        {
            var existingOrderDetail = OrderDetails.FirstOrDefault(o => o.ProductId == newOrderDetail.ProductId);
            if(existingOrderDetail != default)
            {
                orderDetails.Add(new OrderDetail { ProductId = existingOrderDetail.ProductId, 
                                                   UnitPrice = existingOrderDetail.UnitPrice, 
                                                   Quantity = (short) (existingOrderDetail.Quantity + newOrderDetail.Quantity) });
                orderDetails.Remove(existingOrderDetail);
            }
        }
    }
}
