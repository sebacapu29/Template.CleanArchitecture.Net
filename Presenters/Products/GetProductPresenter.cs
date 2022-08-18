using DTOs.Products;
using Presenters.Abstractions;
using UseCases.Abstractions.Products.OutputPorts;

namespace Presenters.Products
{
    internal class GetProductPresenter : IGetProductOutputPort, IPresenter<GetProductDTO>
    {
        public GetProductDTO? Content { get; private set; }

        public async Task HandleAsync(GetProductDTO responseDTO)
        {
            Content = responseDTO;
            await Task.CompletedTask;
        }
    }
}
