using EKart.Data;
using EKart.Models;
using EKart.ViewModels.DegreeProgramViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EKart.Controllers
{
    public class DegreeProgramController : Controller
    {
        //Global variable for this class _context
        private readonly EKartContext _context;

        //This is a constructor of EKart
        public DegreeProgramController(EKartContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //Get The data from database and store it into list i.e. model and this is called querable data when we write ToList() then it becomes fast 
            // because it comes into RAM It is a Enumerable data
            var list = _context.DegreePrograms.AsNoTracking().ToList();
            //Now convert the list data into viewModel because view understand viewmodel
            var viewModelList = new List<DegreeProgramViewModel>();
            foreach (var degree in list)
            {
                viewModelList.Add(new DegreeProgramViewModel
                {
                    DegreeProgramTitle = degree.Title,
                    SerialNumber = degree.Id
                });
            }
            return View(viewModelList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateDegreeProgramViewModel vm)
        {
            var model = new DegreeProgram
            {
                Title = vm.DegreeProgramTitle
            };
            _context.DegreePrograms.Add(model);
            _context.SaveChanges();  
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int degId)
        {
            var model = _context.DegreePrograms.FirstOrDefault(x => x.Id == degId);
            if (model == null)
            {
                return NotFound();
            }
            
            var viewModel = new EditDegreeProgramViewModel
            {
                DegreeProgramId = model.Id,
                DegreeProgramViewModel = new CreateDegreeProgramViewModel
                {
                    DegreeProgramTitle = model.Title
                }
             };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(EditDegreeProgramViewModel vm)
        {
            var model = _context.DegreePrograms.FirstOrDefault(x => x.Id == vm.DegreeProgramId);
            if (model == null)
            {
                return NotFound();
            }
            model.Title = vm.DegreeProgramViewModel.DegreeProgramTitle;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int degId)
        {
            var model = _context.DegreePrograms.FirstOrDefault(x => x.Id == degId);
            if (model==null)
            {
                return NotFound();
            }
            _context.DegreePrograms.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
