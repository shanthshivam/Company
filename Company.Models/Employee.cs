﻿using Company.Models;
using System.ComponentModel.DataAnnotations;
namespace Company.Models

{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
    }
}