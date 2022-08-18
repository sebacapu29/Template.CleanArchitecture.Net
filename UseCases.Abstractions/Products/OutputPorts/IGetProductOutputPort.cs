using DTOs.Products;

namespace UseCases.Abstractions.Products.OutputPorts
{
    public interface IGetProductOutputPort
    {
        Task HandleAsync(GetProductDTO responseDTO);
    }
}
