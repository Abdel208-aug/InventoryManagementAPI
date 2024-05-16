using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv.Models.ModelsDB
{
    public class Warehouse
    {
        [Key]
        public int WarehouseId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
