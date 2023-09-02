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
    public class CategoryBusiness
    {
        CategoryDB db = new CategoryDB();


        public void DeleteCategory(int id)
        {
            db.DeleteCategory(id);
        }


        public void UpdateCategory(E_Category Cat)
        {
            db.UpdateCategory(Cat);
        }


        public void SaveCategory(E_Category Cat)
        {
            if (Cat.Id > 0)
            {
                db.UpdateCategory(Cat);
            }
            else
            {
                db.InsertCategory(Cat);
            }
        }


        public List<E_Category> ViewCategories()
        {
            return db.ViewCategories();
        }


        public List<E_Category> ViewCategoriesById(int id)
        {
            return db.ViewCategoriesById(id);
        }

        public List<E_Category> SearchCategory(string categoryname, string categorycode)
        {
            return db.SearchCategory(categoryname,categorycode);
        }
    }
}
