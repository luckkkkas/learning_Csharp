using MVCApi.Data;
using MVCApi.Models;

namespace MVCApi.Services
{
    public class DepartmentService
    {
        private readonly MVCApiContext _context;
        public DepartmentService(MVCApiContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            Console.WriteLine(obj.Department);
            _context.SaveChanges();
        }
    }
}