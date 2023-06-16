using System;
using System.ComponentModel.DataAnnotations;
namespace DataAnnotation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id is Mandatory")]
        public int EmployeeId { set; get; }

		[Required(ErrorMessage ="Name is Mandatory")]
        public string? EmployeeName { set; get; }

        [Required(ErrorMessage = "Age is Mandatory")]
        public string? EmployeeAge { set; get; }

        [Required(ErrorMessage = "Gender is Mandatory")]
        [StringLength(1,ErrorMessage="Euta string hal gandu")]
        public string? EmployeeGender { set; get; }

        [Required(ErrorMessage = "Email is Mandatory")]
        public string? EmployeeEmail { set; get; }


    }
}

