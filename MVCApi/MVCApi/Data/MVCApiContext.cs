using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<MVCApi.Models.Department> Department { get; set; } = default!;
    }
}
