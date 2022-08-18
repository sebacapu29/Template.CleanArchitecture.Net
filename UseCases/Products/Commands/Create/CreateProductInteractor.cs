using DTOs.Products;
using UseCases.Abstractions.Products.InputPorts;

namespace UseCases.Interactors.Products.Commands.Create
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        public Task HandleAsync(CreateProductDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
