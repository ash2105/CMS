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
    public class itemBusiness
    {
        itemDB db = new itemDB();


        public void DeleteItem(int id)
        {
            db.DeleteItem(id);
        }


        public void UpdateItem(e_item item)
        {
            db.UpdateItem(item);
        }


        public void SaveItem(e_item item)
        {
            if (item.id > 0)
            {
                db.UpdateItem(item);
            }
            else
            {
                db.InsertItem(item);
            }
        }


        public List<e_item> GetAllItems()
        {
            return db.GetAllItems();
        }


        public List<e_item> GetItemById(int id)
        {
            return db.GetItemByID(id);
        }

        public List<e_item> SearchItem(string productname, string productcode)
        {
            return db.SearchItemByproductnameAndCode(productname, productcode);
        }
    }

}
