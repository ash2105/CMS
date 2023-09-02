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
   public class CompanyBusiness
    {

        companyDB db = new companyDB();


        public List<E_Company> getAllCompanies()
        {
            return db.GetAllCompanies();
        }


        public List<E_Company>getCompanyByID(int id)
        {
            return db.GetCompanyByID(id);
        }

        public List<E_Company> SearchCompany(string companyname, string email)
        {
            return db.SearchCompany(companyname, email);
        }


        public void updateCompany(E_Company com)
        {
            db.UpdateCompany(com);
        }


        public void deleteCompany(int id)
        {
            db.DeleteCompany(id);
        }


        public void SaveCompany(E_Company comp)
        {
            if (comp.id > 0)
            {
                db.UpdateCompany(comp);
            }
            else
            {
                db.InsertCompany(comp);
            }
        }
    }

}
