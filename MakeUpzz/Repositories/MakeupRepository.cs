using MakeUpzz.Factories;
using MakeUpzz.Models;
using MakeUpzz.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class MakeupRepository
    {
        private static MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Makeup> getAllMakeups()
        {
            return (from x in db.Makeups select x).ToList();
        }

        public static int getMakeupPrice(int id)
        {
            return (from x in db.Makeups where x.MakeupID == id select x.MakeupPrice).FirstOrDefault();
        }

        public static int getMakeupIDByName(String name)
        {
            return (from x in db.Makeups where x.MakeupName == name select x.MakeupID).FirstOrDefault();
        }

        public static void RemoveMakeupById(int id)
        {
            Makeup makeup = db.Makeups.Find(id);
            List<Cart> cart = CartRepository.getCartByMakeupID(id);
            db.Carts.RemoveRange(cart);
            List<TransactionDetail> td = TransactionDetailRepository.getTransactionDetailByMakeupID(id);
            db.TransactionDetails.RemoveRange(td);
            db.Makeups.Remove(makeup);
            db.SaveChanges();
        }

        public static Makeup GetMakeupByID(int id)
        {
            Makeup makeup = db.Makeups.Find(id);
            return makeup;
        }

        public static List<Makeup> GetMakeupByTypeID(int typeID)
        {
            List<Makeup> makeup = (from x in db.Makeups where x.MakeupTypeID == typeID select x).ToList();
            return makeup;
        }

        public static List<Makeup> GetMakeupByBrandID(int brandID)
        {
            List<Makeup> makeup = (from x in db.Makeups where x.MakeupBrandID == brandID select x).ToList();
            return makeup;
        }

            public static void UpdateMakeupByID(int id, String name, int price, int weight, int makeupTypeID, int makeupBrandID)
        {
            Makeup updatemakeup = GetMakeupByID(id);
            updatemakeup.MakeupName = name;
            updatemakeup.MakeupPrice = price;
            updatemakeup.MakeupWeight = weight;
            updatemakeup.MakeupTypeID = makeupTypeID;
            updatemakeup.MakeupBrandID = makeupBrandID;
            db.SaveChanges();
        }

        public static int getLastMakeupID()
        {
            return (from x in db.Makeups select x.MakeupID).ToList().LastOrDefault();
        }

        public static int generateMakeupID()
        {
            int lastID = getLastMakeupID();

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

        public static void insertMakeup(String name, int price, int weight, int typeID, int brandID)
        {
            int makeupID = generateMakeupID();
            Makeup makeup = MakeupFactory.Create(makeupID, name, price, weight, typeID, brandID);
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }
    }
}