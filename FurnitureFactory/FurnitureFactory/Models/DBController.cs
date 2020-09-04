using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    class DBController
    {
        static FFContext db;
        static DBController()
        {
            db = new FFContext();
        }
        internal static User LoggedUser(string login, string password)
        {
            db.User.Load();
            List<User> users = db.User.ToList();
            foreach (var user in users)
            {
                if (user.Login == login && user.Password == password)
                    return user;
            }
            return null;
        }

        internal static User FindUser(int id)
        {
            db.User.Load();
            List<User> users = db.User.ToList();
            foreach (var user in users)
            {
                if (user.IdUser == id)
                    return user;
            }
            return null;
        }
    }
}
