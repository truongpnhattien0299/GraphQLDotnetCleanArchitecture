using DemoGraphQL.Application.Exceptions;
using DemoGraphQL.Application.Interfaces.Repositories;
using DemoGraphQL.Application.Wrappers;
using DemoGraphQL.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoGraphQL.Application.Features.Product.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<Response<Products>>
    {
        public int Id { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Response<Products>>
        {
            private readonly IProductRepositoryAsync _productRepository;
            public GetProductByIdQueryHandler(IProductRepositoryAsync productRepository)
            {
                _productRepository = productRepository;
            }
            public async Task<Response<Products>> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(query.Id);
                if (product == null) throw new ApiException($"Product Not Found.");
                return new Response<Products>(product);
            }
        }
    }
}
