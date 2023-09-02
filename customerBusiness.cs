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
    public class customerBusiness
    {
        CustomerDB db = new CustomerDB();

        public List<e_customer> GetAllCustomers()
        {
            return db.GetAllCustomers();
        }


        public List<e_customer> GetCustomerById(int id)
        {
           return  db.GetCustomerById(id);
        }

        public List<e_customer> SearchCustomer(string customername, string companyname)
        {
            return db.SearchByCustomerNameAndCompanyName(customername,companyname);
        }


        public void DeleteCustomer(int id)
        {
            db.DeleteCustomer(id);
        }


        public void UpdateCustomer(e_customer cust)
        {
            db.UpdateCustomer(cust);
        }


        public void SaveCustomer(e_customer cust)
        {
            if (cust.id > 0)
            {
                db.UpdateCustomer(cust);
            }
            else
            {
                db.InsertCustomer(cust);
            }
        }
    }
}
