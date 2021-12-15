using System;
using System.Collections.Generic;

namespace DemoGraphQL.Domain.Entities
{
    public partial class Offices
    {
        public Offices()
        {
            Employees = new HashSet<Employees>();
        }

        public string OfficeCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Territory { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
