using Payroll.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Domain.Usecases
{
    public interface IEmployeeRepo
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
    
        void DeleteEmployee(Employee employee);
    }
}
