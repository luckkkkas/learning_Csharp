using Microsoft.EntityFrameworkCore;
using MVCApi.Models;

namespace MVCApi.Data
{
    public class MVCApiContext : DbContext
    {
        public MVCApiContext (DbContextOptions<MVCApiContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
