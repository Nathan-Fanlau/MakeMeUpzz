using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class UserRepository
    {
        private static MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static bool IsUsernameUnique(string username)
        {
            return !db.Users.Any(u => u.Username == username); //Pake LINQ
        }

        public static bool IsLoginValid(string username, string password)
        {
            return db.Users.Any(u => u.Username == username && u.UserPassword == password);
        }

        public static User GetUserByNameAndPassword(string username, string password)
        {
            return (from x in db.Users
                    where x.Username == username && x.UserPassword == password
                    select x).FirstOrDefault();
        }

        public static User getUserByName(string username)
        {
            return (from x in db.Users
                    where x.Username.Equals(username)
                    select x).FirstOrDefault();
        }

        public static List<User> getCustomerList()
        {
            return (from x in db.Users
                    where x.UserRole == "Customer"
                    select x).ToList();
        }
    }
}