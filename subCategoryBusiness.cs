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
    public class subCategoryBusiness
    {

        SubCategoryDB db = new SubCategoryDB();


        public List<e_subCategory> getAllSubcategories()
        {
           return  db.GetAllSubCategories();
        }


        public List<e_subCategory> getSubcategoryById(int id)
        {
            return db.GetSubCategorybyID(id);
        }


        public void updateSubcategory(e_subCategory s_cat)
        {
            db.UpdateSubCategory(s_cat);
        }


        public void deleteSubcategory(int id)
        {
            db.DeleteSubCategory(id);
        }


        public void SaveSub(e_subCategory sub)
        {
            if (sub.id > 0)
            {
                db.UpdateSubCategory(sub);
            }
            else
            {
                db.InsertSubCategory(sub);
            }
        }
        public List<e_subCategory> SearchSubCategoryByNameAndCode(string subcategoryname, string subcategorycode)
        {
            return db.SearchSubCategory(subcategoryname,subcategorycode);
        }
    }
}
