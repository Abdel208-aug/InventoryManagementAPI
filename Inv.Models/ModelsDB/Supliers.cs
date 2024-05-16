﻿using System;
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
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public List<Products> Products { get; set; }
    }
}
