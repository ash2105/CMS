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
    public class BillingItemBusiness
    {

        BillingItemDB db = new BillingItemDB();


        public List<E_BillItem> ViewAllBillItems()
        {
            return db.ViewAllBillItems();
        }


        public List<E_BillItem> ViewBillItemById(int id)
        {
            return db.ViewBillItemById(id);
        }

        public List<E_BillItem> SearchBillItem(int itemid,int qty)
        {
            return db.SearchBillItem(itemid,qty);
        }


        public void updateBillingItem(E_BillItem b_item)
        {
            db.UpdateBillItem(b_item);
        }


        public void deleteBillingItem(int id)
        {
            db.DeleteBillItem(id);
        }


        public void SaveBillingItem(E_BillItem billItem)
        {
            if (billItem.Id > 0)
            {
                db.UpdateBillItem(billItem);
            }
            else
            {
                db.InsertBillItem(billItem);
            }
        }
    }

}
