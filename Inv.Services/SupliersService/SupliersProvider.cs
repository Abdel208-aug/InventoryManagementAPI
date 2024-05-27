using Inv.Models.ModelsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv.Services.SupliersService
{
    public class SupliersProvider
    {
        private InvContextDB _db;

        public SupliersProvider(InvContextDB db)
        {
            _db = db;
        }

        public IEnumerable<Supliers> GetSupliers()
        {
            return _db.Supliers;
        }
        public string AddSuplier(Supliers suplier)
        {

            try
            {
                _db.Supliers.Add(suplier);
                _db.SaveChanges();
                return "Added successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string EditSuplier(Supliers suplier)
        {
            try
            {
                _db.Supliers.Update(suplier);
                _db.SaveChanges();
                return "suplier Updated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string DeleteSuplier(Supliers suplier)
        {
            try
            {
                _db.Supliers.Remove(suplier);
                _db.SaveChanges();
                return "suplier Removed successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
