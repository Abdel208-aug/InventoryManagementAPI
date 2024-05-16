using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv.Models.ModelsDB
{
    public class InvContextDB : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Supliers> Supliers { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }

        public InvContextDB(DbContextOptions<InvContextDB> options) : base(options)
        {
            
        }
    }
}
