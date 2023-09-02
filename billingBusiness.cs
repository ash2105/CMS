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
    public class billingBusiness
    {

        BillDb  db = new BillDb();


        public List<E_BILL> ViewAllBill()
        {
            return db.ViewAllBill();
        }


        public List<E_BILL> ViewBillById(int Id)
        {
            return db.ViewBillById(Id);
        }


        public void UpdateBill(E_BILL bill)
        {
            db.UpdateBill(bill);
        }


        public void DeleteBill(int Id)
        {
            db.DeleteBill(Id);
        }


        public void SaveBill(E_BILL bill)
        {
            if (bill.Id > 0)
            {
                db.UpdateBill(bill);
            }
            else
            {
                db.InsertBill(bill);
            }
        }
        public List<E_BILL> SearchBill(string billno, string invoicedate)
        {
            return db.SearchBill(billno,invoicedate);
        }
    }
}
