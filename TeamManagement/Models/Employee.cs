using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamManagement.Models
{
    public class Employee
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Teamname { get; set; }
        public string Email { get; set; }

        public int Userid { get; set; }

        public List<Employee> GetEmployees()
        {
            var Employees = new List<Employee> {
                new Employee
                {
                    Userid = 1,
                    Username = "Emp1",
                    Password="pw1",
                    Email="t1@t1.com",
                    Teamname="MortgageBot"
                },
                new Employee
                {
                    Userid = 2,
                    Username = "Emp2",
                    Password="pw2",
                    Email="t2@t1.com",
                    Teamname="Laserpro"
                },
                new Employee
                {
                    Userid = 3,
                    Username = "Emp3",
                    Password="pw3",
                    Email="t3@t1.com",
                    Teamname="LaserproImp"
                },
                new Employee
                {
                   Userid = 4,
                    Username = "Emp4",
                    Password="pw4",
                     Email="t4@t1.com",
                    Teamname="DocumentService"
                },
                new Employee
                {
                    Userid = 5,
                    Username = "Emp5",
                    Password="pw5",
                    Email="t5@t1.com",
                    Teamname="MortgageBot"
                },
                new Employee
                {
                    Userid = 6,
                    Username = "Emp6",
                    Password="pw6",
                    Email="t6@t1.com",
                    Teamname="MortgageBot"
                },
            };

            return Employees;
        }

    }
}