﻿using Inv.Models.ModelsDB;
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

        public ProductsProvider(InvContextDB db)
        {
            _db = db;
        }

        public IEnumerable<Products> GetProducts()
        {
            return _db.Products;
        }
        public string AddProduct (Products product)
        {
            try
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return "Added successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
                
            }
        }
        public string EditProduct(Products product)
        {
            try
            {
                _db.Products.Update(product);
                _db.SaveChanges();
                return "Product Updated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string DeleteProduct(Products product)
        {
            try
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
                return "Product Removed successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
