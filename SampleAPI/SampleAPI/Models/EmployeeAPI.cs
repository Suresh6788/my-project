﻿using System.ComponentModel.DataAnnotations;

namespace SampleAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
