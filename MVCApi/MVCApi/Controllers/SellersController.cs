using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCApi.Data;
using MVCApi.Models;
using MVCApi.Services;

namespace MVCApi.Controllers
{
    public class SellersController : Controller
    {
        private readonly MVCApiContext _context;
        private readonly SellerService _sellerService;

        public SellersController(MVCApiContext context, SellerService sellerService)
        {
            _context = context;
            _sellerService = sellerService;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
