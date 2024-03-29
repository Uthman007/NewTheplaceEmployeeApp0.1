﻿using System.ComponentModel.DataAnnotations;
using  TheplaceEmployeeApp.Data.Enums;



namespace TheplaceEmployeeApp.Data.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Employee name must have 3 or more character")]
        [MaxLength(50, ErrorMessage = "Maximum number character exceeded")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Employee name must have 3 or more character")]
        [MaxLength(50, ErrorMessage = "Maximum number character exceeded")]
        public string LastName { get; set; }

        [MinLength(3, ErrorMessage = "Employee name must have 3 or more character")]
        [MaxLength(50, ErrorMessage = "Maximum number character exceeded")]
        public string MiddleName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string ResidentialAddress { get; set; }

        [Required, Range(18, 100, ErrorMessage = "Please enter valid Age")]
        public int Age { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime DateEmployed { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public SkinColor SkinColor { get; set; }

        [Required]
        public BranchName BranchName { get; set; }

        [Required]
        public Department Department { get; set; }

        [Required]
        public StateName StateName { get; set; }

        [Required]
        public Designation Designation { get; set; }    

    }
}
