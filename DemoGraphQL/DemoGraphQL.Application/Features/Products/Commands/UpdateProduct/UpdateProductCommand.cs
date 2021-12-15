using DemoGraphQL.Application.Exceptions;
using DemoGraphQL.Application.Interfaces.Repositories;
using DemoGraphQL.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoGraphQL.Application.Features.Product.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<Response<int>>
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductLine { get; set; }
        public string ProductScale { get; set; }
        public string ProductVendor { get; set; }
        public string ProductDescription { get; set; }
        public short QuantityInStock { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal Msrp { get; set; }
        public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Response<int>>
        {
            private readonly IProductRepositoryAsync _productRepository;
            public UpdateProductCommandHandler(IProductRepositoryAsync productRepository)
            {
                _productRepository = productRepository;
            }
            public async Task<Response<int>> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByCodeAsync(command.ProductCode);

                if (product == null)
                {
                    throw new ApiException($"Product Not Found.");
                }
                else
                {
                    product.ProductName = command.ProductName;
                    product.BuyPrice = command.BuyPrice;
                    product.ProductDescription = command.ProductDescription;
                    await _productRepository.UpdateAsync(product);
                    return new Response<int>(product.ProductCode);
                }
            }
        }
    }
}
