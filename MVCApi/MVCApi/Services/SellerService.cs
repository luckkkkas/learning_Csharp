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
            _context.SaveChanges();
        }
    }
}
