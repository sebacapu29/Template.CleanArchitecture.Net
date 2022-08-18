using DTOs.Products;

namespace UseCases.Abstractions.Products.InputPorts
{
    public interface IGetProductInputPort
    {
        Task HandleAsync(GetProductDTO assetRequestDTO);
    }
}
