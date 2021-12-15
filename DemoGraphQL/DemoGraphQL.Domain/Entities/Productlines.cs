using System;
using System.Collections.Generic;

namespace DemoGraphQL.Domain.Entities
{
    public partial class Productlines
    {
        public Productlines()
        {
            Products = new HashSet<Products>();
        }

        public string ProductLine { get; set; }
        public string TextDescription { get; set; }
        public string HtmlDescription { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
