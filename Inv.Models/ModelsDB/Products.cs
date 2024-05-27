using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv.Models.ModelsDB
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public string LotNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CategorieId { get; set; }
        public int SuplierId { get; set; }

        public Categories? Categorie { get; set; }
        public Supliers? Suplier { get; set; }
    }
}
