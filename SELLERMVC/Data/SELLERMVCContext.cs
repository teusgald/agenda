using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SELLERMVC.Models;

namespace SELLERMVC.Data
{
    public class SELLERMVCContext : DbContext
    {
        public SELLERMVCContext (DbContextOptions<SELLERMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }

        public DbSet<Seller> Seller { get; set; }

        public DbSet<SalesRecord> SalesRecord{ get; set; }
    }
}
