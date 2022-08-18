using DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Abstractions.Products.InputPorts;
using UseCases.Abstractions.Products.OutputPorts;

namespace UseCases.Interactors.Products.Queries.GetProduct
{
    public class GetProductInteractor : IGetProductInputPort
    {
        private IGetProductOutputPort _productOutputPort;

        public GetProductInteractor(IGetProductOutputPort productOutputPort)
        {
            _productOutputPort = productOutputPort;
        }

        public Task HandleAsync(GetProductDTO assetRequestDTO)
        {
            throw new NotImplementedException();
        }
    }
}
