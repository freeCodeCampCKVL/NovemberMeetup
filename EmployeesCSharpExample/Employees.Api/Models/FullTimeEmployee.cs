using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employees.Api.Models
{
    public class FullTimeEmployee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
    }
}