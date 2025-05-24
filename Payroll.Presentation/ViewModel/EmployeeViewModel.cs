using Payroll.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Presentation.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmployeeNo { get; set; }
        public Gender Gender { get; set; }
        public string ImageUrl {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoined { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Designation {  get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public StudentLoan StudentLoan { get; set; }

    }
}
