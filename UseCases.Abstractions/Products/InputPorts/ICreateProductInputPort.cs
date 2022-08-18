using DTOs.Products;

namespace UseCases.Abstractions.Products.InputPorts
{
    public interface ICreateProductInputPort
    {
        Task HandleAsync(CreateProductDTO request);
    }
}
