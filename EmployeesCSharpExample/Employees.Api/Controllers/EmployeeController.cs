﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;

namespace Employees.Api.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Models.Employee> myListEmployees = new List<Models.Employee>();
        List<Models.Employee> myDbEmployees = new List<Models.Employee>();

        public EmployeeController()
        {
            //List Data
            myListEmployees.Add(new Models.Employee { Id = 1, FirstName = "Test", LastName = "User 1", Email = "testuser1@email.com", Gender = "Male", HireDate = DateTime.Now });
            myListEmployees.Add(new Models.Employee { Id = 2, FirstName = "Test", LastName = "User 2", Email = "testuser2@email.com", Gender = "Female", HireDate = DateTime.Now.AddDays(-20) });
            myListEmployees.Add(new Models.Employee { Id = 3, FirstName = "Test", LastName = "User 3", Email = "testuser3@email.com", Gender = "Male", HireDate = DateTime.Now.AddDays(-60) });
        }

        // GET: api/Employee
        public IEnumerable<Models.Employee> Get()
        {
            ////From Database
            //string connStr = WebConfigurationManager.ConnectionStrings["EmployeeDBContext"].ConnectionString;
            //var connection = new SqlConnection(connStr);
            //using (connection)
            //{
            //    SqlCommand command = new SqlCommand("SELECT * FROM EmployeeDB.dbo.Employee", connection);
            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        myDbEmployees.Add(new Models.Employee()
            //        {
            //            Id = (int)reader["Id"],
            //            FirstName = (string)reader["FirstName"],
            //            LastName = (string)reader["LastName"],
            //            Email = (string)reader["Email"],
            //            Gender = (string)reader["Gender"]
            //        });
            //    }

            //    reader.Close();
            //    connection.Dispose();
            //}
            ////return myDbEmployees;

            //From List
            return myListEmployees;
        }

            // GET: api/Employee/5
            public Models.Employee Get(int id)
        {
            Models.Employee myEmployee = new Models.Employee();
            Models.Employee myDbEmployee = new Models.Employee();

            ////From Database
            //string connStr = WebConfigurationManager.ConnectionStrings["EmployeeDBContext"].ConnectionString;
            //var connection = new SqlConnection(connStr);
            //using (connection)
            //{
            //    SqlCommand command = new SqlCommand("SELECT * FROM EmployeeDB.dbo.Employee", connection);
            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        myDbEmployees.Add(new Models.Employee()
            //        {
            //            Id = (int)reader["Id"],
            //            FirstName = (string)reader["FirstName"],
            //            LastName = (string)reader["LastName"],
            //            Email = (string)reader["Email"],
            //            Gender = (string)reader["Gender"]
            //        });
            //    }

            //    reader.Close();
            //    connection.Dispose();
            //}
            //myDbEmployee = (Models.Employee)myDbEmployees.Where(x => x.Id == id).FirstOrDefault();
            ////return myDbEmployees;

            //From List
            myEmployee = (Models.Employee)myListEmployees.Where(x => x.Id == id).FirstOrDefault();


            return myEmployee;
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
