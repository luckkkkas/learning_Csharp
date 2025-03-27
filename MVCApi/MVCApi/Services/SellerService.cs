using MVCApi.Data;
using MVCApi.Models;

namespace MVCApi.Services
{
    public class SellerService
    {
        private readonly MVCApiContext _context;
        public SellerService(MVCApiContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            Console.WriteLine(obj.Department);
            _context.SaveChanges();
        }

        public Seller FindById(int id) 
        {
            return _context.Seller.FirstOrDefault(item => item.Id ==  id);    
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
