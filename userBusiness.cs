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
    public class userBusiness
    {

        userDB db = new userDB();


        public List<e_user> getAllUsers()
        {
            return db.GetAllUsers();
        }


        public List<e_user> getUserById(int id)
        {
            return db.GetUserByID(id);
        }

        public List<e_user> SearchUser(string username,string userrole)
        {
            return db.SearchUser(username,userrole);
        }

        public void updateUser(e_user user)
        {
            db.UpdateUser(user);
        }


        public void deleteUser(int id)
        {
            db.DeleteUser(id);
        }


        public void SaveUser(e_user user)
        {
            if (user.id > 0)
            {
                db.UpdateUser(user);
            }
            else {
                db.InsertUser(user);
            }
        }
    }
}
