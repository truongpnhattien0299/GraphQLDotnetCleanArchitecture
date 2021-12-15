using System;
using System.Collections.Generic;

namespace DemoGraphQL.Domain.Entities
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
            Payments = new HashSet<Payments>();
        }

        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int? SalesRepEmployeeNumber { get; set; }
        public decimal? CreditLimit { get; set; }

        public virtual Employees SalesRepEmployeeNumberNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
