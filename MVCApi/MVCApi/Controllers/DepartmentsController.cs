using Microsoft.AspNetCore.Mvc;
using MVCApi.Models;

namespace MVCApi.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Roupas" });
            departments.Add(new Department { Id = 1, Name = "Ferramentas" });
            return View(departments);
        }
    }
}
