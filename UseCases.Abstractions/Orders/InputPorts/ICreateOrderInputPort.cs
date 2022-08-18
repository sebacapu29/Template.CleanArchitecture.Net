using DTOs.Orders;

namespace UseCases.Abstractions.Orders.InputPorts
{
    public interface ICreateOrderInputPort
    {
        Task HandleAsync(CreateOrderDTO request);
    }
}
