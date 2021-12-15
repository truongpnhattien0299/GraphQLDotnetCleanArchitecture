using System;
using System.Collections.Generic;

namespace DemoGraphQL.Domain.Entities
{
    public partial class Payments
    {
        public int CustomerNumber { get; set; }
        public string CheckNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }

        public virtual Customers CustomerNumberNavigation { get; set; }
    }
}
