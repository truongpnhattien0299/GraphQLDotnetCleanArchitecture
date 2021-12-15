using AutoMapper;
using DemoGraphQL.Application.Features.Product.Commands.CreateProduct;
using DemoGraphQL.Application.Features.Product.Queries.GetAllProducts;
using DemoGraphQL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Products, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Products>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
