using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Presentation.ViewModel
{
    public class EditEmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public CreateEmployeeViewModel EmployeeData { get; set; }
    }
}
