using AutoMapper;
using DemoGraphQL.Application.Interfaces.Repositories;
using DemoGraphQL.Application.Wrappers;
using DemoGraphQL.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DemoGraphQL.Application.Features.Product.Commands.CreateProduct
{
    public partial class CreateProductCommand : IRequest<Response<int>>
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
    }
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Response<int>>
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepositoryAsync productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Products>(request);
            await _productRepository.AddAsync(product);
            return new Response<int>(product.ProductCode);
        }
    }
}
