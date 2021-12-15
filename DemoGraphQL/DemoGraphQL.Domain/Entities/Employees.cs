using System;
using System.Collections.Generic;

namespace DemoGraphQL.Domain.Entities
{
    public partial class Employees
    {
        public Employees()
        {
            Customers = new HashSet<Customers>();
            InverseReportsToNavigation = new HashSet<Employees>();
        }

        public int EmployeeNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string OfficeCode { get; set; }
        public int? ReportsTo { get; set; }
        public string JobTitle { get; set; }

        public virtual Offices OfficeCodeNavigation { get; set; }
        public virtual Employees ReportsToNavigation { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Employees> InverseReportsToNavigation { get; set; }
    }
}
