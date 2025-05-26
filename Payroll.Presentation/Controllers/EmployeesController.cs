using Microsoft.AspNetCore.Mvc;
using Payroll.Domain.Entities;
using Payroll.Domain.Usecases;
using Payroll.Presentation.ViewModel;

namespace Payroll.Presentation.Controllers
{
    public class EmployeesController : Controller
    {
        public readonly IEmployeeRepo _employeeRepo;
        public EmployeesController(IEmployeeRepo employeeRepo) //Called Constructor Dependency Injection 
        {
            _employeeRepo = employeeRepo;
        }

        public IActionResult Index()
        {

            var employees = _employeeRepo.GetAllEmployees();
            var viewModel = new List<EmployeeViewModel>();
            foreach (var employee in employees)
            {
                viewModel.Add(new EmployeeViewModel
                {  //Id = employee.Id,
                    EmployeeNo = employee.EmployeeNo,
                    FullName = employee.FullName,
                    Gender = employee.Gender,
                    ImageUrl = employee.ImageUrl,
                    DateOfBirth = employee.DateOfBirth,
                    DateOfJoined = employee.DateOfJoined,
                    Phone = employee.Phone,
                    Email = employee.Email,
                    Address = employee.Address,
                    City = employee.City,
                    PostalCode = employee.PostalCode,
                    Designation = employee.Designation,
                    PaymentMethod = employee.PaymentMethod,
                    StudentLoan = employee.StudentLoan
                });
            }
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateEmployeeViewModel vm)
        {
            var employee = new Employee
            {
                EmployeeNo = vm.EmployeeNo,
                FullName = vm.FullName,
                Gender = vm.Gender,
                ImageUrl = vm.ImageUrl,
                DateOfBirth = vm.DateOfBirth,
                DateOfJoined = vm.DateOfJoined,
                Phone = vm.Phone,
                Email = vm.Email,
                Address = vm.Address,
                City = vm.City,
                PostalCode = vm.PostalCode,
                Designation = vm.Designation,
                PaymentMethod = vm.PaymentMethod,
                StudentLoan = vm.StudentLoan

            };
            _employeeRepo.AddEmployee(employee);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var employee = _employeeRepo.GetEmployeeById(Id);
            var viewModelList = new EditEmployeeViewModel
            {
                EmployeeID = employee.Id,
                EmployeeData = new CreateEmployeeViewModel
                {
                    EmployeeNo = employee.EmployeeNo,
                    FullName = employee.FullName,
                    Gender = employee.Gender,
                    ImageUrl = employee.ImageUrl,
                    DateOfBirth = employee.DateOfBirth,
                    DateOfJoined = employee.DateOfJoined,
                    Phone = employee.Phone,
                    Email = employee.Email,
                    Address = employee.Address,
                    City = employee.City,
                    PostalCode = employee.PostalCode,
                    Designation = employee.Designation,
                    PaymentMethod = employee.PaymentMethod,
                    StudentLoan = employee.StudentLoan
                }

            };
            return View(viewModelList);
        }

        [HttpPost]
        public IActionResult Edit(EditEmployeeViewModel vm)
        {
            var employee = new Employee
            {
                EmployeeNo = vm.EmployeeData.EmployeeNo,
                FullName = vm.EmployeeData.FullName,
                Gender = vm.EmployeeData.Gender,
                ImageUrl = vm.EmployeeData.ImageUrl,
                DateOfBirth = vm.EmployeeData.DateOfBirth,
                DateOfJoined = vm.EmployeeData.DateOfJoined,
                Phone = vm.EmployeeData.Phone,
                Email = vm.EmployeeData.Email,
                Address = vm.EmployeeData.Address,
                City = vm.EmployeeData.City,
                PostalCode = vm.EmployeeData.PostalCode,
                Designation = vm.EmployeeData.Designation,
                PaymentMethod = vm.EmployeeData.PaymentMethod,
                StudentLoan = vm.EmployeeData.StudentLoan
            };
            _employeeRepo.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var employee = _employeeRepo.GetEmployeeById(Id);
            if(employee==null)
            {
                return NotFound();
            }
            _employeeRepo.DeleteEmployee(employee);
            return RedirectToAction("Index");
           
        }
    }
}
