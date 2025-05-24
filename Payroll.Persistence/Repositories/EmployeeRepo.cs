using Payroll.Domain.Entities;
using Payroll.Domain.Usecases;
using Payroll.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Persistence.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            var employee1 = _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
            
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _context.Employees.Find(id);
            return employee;
            
        }

        public void UpdateEmployee(Employee employee)
        {
            var employee1 = _context.Employees.Update(employee);
            _context.SaveChanges();
        }
    }
}
