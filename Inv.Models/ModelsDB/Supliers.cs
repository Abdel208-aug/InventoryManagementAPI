using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv.Models.ModelsDB
{
    public class Supliers
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public virtual List<Products?>? Products { get; set; }
    }
}
