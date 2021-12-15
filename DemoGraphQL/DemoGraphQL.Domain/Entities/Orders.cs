using System;
using System.Collections.Generic;

namespace DemoGraphQL.Domain.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            Orderdetails = new HashSet<Orderdetails>();
        }

        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int CustomerNumber { get; set; }

        public virtual Customers CustomerNumberNavigation { get; set; }
        public virtual ICollection<Orderdetails> Orderdetails { get; set; }
    }
}
