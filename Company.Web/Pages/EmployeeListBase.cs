﻿using Company.Models;
using Company.Web.Services;
using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Company.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee>? Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //LoadEmployees();
            //return base.OnInitializedAsync();
            Console.WriteLine("before calling Employee services");
            Employees = (await EmployeeService.GetEmployees()).ToList();
            Console.WriteLine("After calling Employee services " + Employees);
        }

        private void LoadEmployees()
        {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                //Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                DepartmentId = 1,
                PhotoPath = "images/john.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                //Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
                DepartmentId = 2,
                PhotoPath = "images/sam.png"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                //Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                DepartmentId = 3,
                PhotoPath = "images/mary.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                //Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
                DepartmentId = 4,
                PhotoPath = "images/sara.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
