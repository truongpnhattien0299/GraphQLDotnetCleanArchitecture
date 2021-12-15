using System;
using System.Collections.Generic;

namespace DemoGraphQL.Domain.Entities
{
    public partial class Products
    {
        public Products()
        {
            Orderdetails = new HashSet<Orderdetails>();
        }

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductLine { get; set; }
        public string ProductScale { get; set; }
        public string ProductVendor { get; set; }
        public string ProductDescription { get; set; }
        public short QuantityInStock { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal Msrp { get; set; }

        public virtual Productlines ProductLineNavigation { get; set; }
        public virtual ICollection<Orderdetails> Orderdetails { get; set; }
    }
}
