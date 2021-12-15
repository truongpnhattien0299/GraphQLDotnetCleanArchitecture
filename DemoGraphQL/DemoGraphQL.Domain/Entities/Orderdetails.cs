using System;
using System.Collections.Generic;

namespace DemoGraphQL.Domain.Entities
{
    public partial class Orderdetails
    {
        public int OrderNumber { get; set; }
        public string ProductCode { get; set; }
        public int QuantityOrdered { get; set; }
        public decimal PriceEach { get; set; }
        public short OrderLineNumber { get; set; }

        public virtual Orders OrderNumberNavigation { get; set; }
        public virtual Products ProductCodeNavigation { get; set; }
    }
}
