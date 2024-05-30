using MakeUpzz.Factories;
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

        public static int getLastUserID()
        {
            return (from x in db.Users select x.UserID).ToList().LastOrDefault();
        }

        public static int generateUserID()
        {
            int lastID = getLastUserID();

            if (lastID == null)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }
            return lastID;
        }

        public static void insertUser(String name, String email, DateTime dob, String gender, String role,
                                        String pw)
        {
            int UserID = generateUserID();
            User user = UserFactory.Create(UserID, name, email, dob, gender, role, pw);
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}