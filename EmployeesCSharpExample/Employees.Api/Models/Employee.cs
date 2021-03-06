﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employees.Api.Models
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Gender { get; set; }
        DateTime HireDate { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
    }
}