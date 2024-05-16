using Inv.Models.ModelsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv.Services.ProductsService
{
    public class ProductsProvider
    {
        private InvContextDB _db;

        public ProductsProvider()
        {
            
        }

        public ProductsProvider(InvContextDB db) : this()
        {
            _db = db;
        }

        public IEnumerable<Products> GetProducts()
        {
            return _db.Products;
        }
    }
}
