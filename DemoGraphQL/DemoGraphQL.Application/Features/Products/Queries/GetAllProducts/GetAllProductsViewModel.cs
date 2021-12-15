using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Application.Features.Product.Queries.GetAllProducts
{
    public class GetAllProductsViewModel
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
}
