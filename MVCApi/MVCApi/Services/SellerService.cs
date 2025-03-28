using MVCApi.Data;
using MVCApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Data;
using MVCApi.Services.Exceptions;

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
            return _context.Seller.Include( obj => obj.Department).FirstOrDefault(item => item.Id ==  id);    
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj) 
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id)) throw new NotFoundException("Id Não Encontrado No banco de dados");
            try 
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DBConcurrencyException ex)
            {
                throw new DbConcurencyException(ex.Message);
            }
        }
    }
}
