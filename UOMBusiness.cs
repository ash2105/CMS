using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DataAccess;
using Entity;

namespace Business
{
    public class UOMBusiness
    {

        UOMDB db = new UOMDB();


        public List<e_UOM> readAllUOM()
        {
            return db.GetAllUOM();
        }


        public List<e_UOM> readUOMById(int id)
        {
            return db.GetUOMByID(id);
        }


        public void updateUOM(e_UOM uom)
        {
            db.UpdateUOM(uom);
        }


        public void deleteUOM(int id)
        {
            db.DeleteUOM(id);
        }


        public void SaveUOM(e_UOM uom)
        {
            if (uom.id > 0)
            {
                db.UpdateUOM(uom);
            }
            else
            {
                db.InsertUOM(uom);
            }
        }
        public List<e_UOM> SearchUOM(string UomName)
        {
            return db.SearchUOM(UomName);
        }
    }
}
