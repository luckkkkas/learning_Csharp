using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;
using MVCApi.Data;
using MVCApi.Models;
using MVCApi.Models.ViewModels;
using MVCApi.Services;
using MVCApi.Services.Exceptions;

namespace MVCApi.Controllers
{
    public class SellersController : Controller
    {
        private readonly MVCApiContext _context;
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(MVCApiContext context, SellerService sellerService, DepartmentService departmentService)
        {
            _context = context;
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel{ Departments = departments };
            return View(viewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id) 
        {
            if (id == null) return NotFound();

            var obj = _sellerService.FindById(id.Value);

            if (obj == null) return NotFound();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
             _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id) 
        {
            var obj = _sellerService.FindById(id);
            return View(obj);
        }

        public IActionResult Edit(int id)
        {
            if (id == null) return NotFound();
           
            var obj = _sellerService.FindById(id);
            
            if (obj == null) return NotFound();

            List<Department> departments = _departmentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            if (id != seller.Id) return BadRequest();

            try
            {
                _sellerService.Update(seller);
            }
            catch (NotFoundException ex)
            {
                return NotFound();
            }
            catch (DbConcurencyException ex) 
            {
                return NotFound();
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}
