using Inv.Models.ModelsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv.Services.CategoriesService
{
    public class CategoriesProvider
    {
        private InvContextDB _db;

        
        public CategoriesProvider(InvContextDB db)
        {
            _db = db;
        }

        public IEnumerable<Categories> GetCategories()
        {
            return _db.Categories;
        }
        public string AddCategory(Categories category)
        {
            try
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return "Added successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string EditCategory(Categories category)
        {
            try
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                return "category Updated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string DeleteCategory(Categories category)
        {
            try
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
                return "category Removed successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
