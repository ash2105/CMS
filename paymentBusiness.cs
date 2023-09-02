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
   public  class paymentBusiness
    {

        paymentDB db = new paymentDB();


        public List<e_payment> getAllPayments()
        {
           return db.GetAllPayments();
        }


        public List<e_payment> getPaymentById(int id)
        {
            return db.GetPaymentByID(id);
        }


        public void updatePayment(e_payment pay)
        {
            db.UpdatePayment(pay);
        }


        public void deletePayment(int id)
        {
            db.DeletePayment(id);
        }


        public void SavePayment(e_payment pay)
        {
            if (pay.id > 0)
            {
                db.UpdatePayment(pay);
            }
            else
            {
                db.InsertPayment(pay);
            }
        }
        public List<e_payment> SearchPayment(int paymentrefno)
        {
            return db.SearchPaymentByPayRefNo(paymentrefno);
        }

    }
}
