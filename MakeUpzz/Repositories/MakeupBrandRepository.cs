using MakeUpzz.Factories;
using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class MakeupBrandRepository
    {
        private static MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<MakeupBrand> getAllMakeupBrands()
        {
            return (from x in db.MakeupBrands
                    orderby x.MakeupBrandRating descending
                    select x).ToList();
        }

        public static int getMakeupBrandIDByName(String name)
        {
            return (from x in db.MakeupBrands where x.MakeupBrandName
                    == name select x.MakeupBrandID).FirstOrDefault();
        }

        public static void RemoveMakeupBrandById(int id)
        {
            //Kalo kita hapus typeID 1, beraarti makeup yang punya id 1 juga ikut kehapus
            MakeupBrand makeupBrand = db.MakeupBrands.Find(id);
            List<Makeup> makeup = MakeupRepository.GetMakeupByBrandID(id);
            db.Makeups.RemoveRange(makeup);
            db.MakeupBrands.Remove(makeupBrand);
            db.SaveChanges();
        }

        public static MakeupBrand GetMakeupBrandByID(int id)
        {
            MakeupBrand makeupBrand = db.MakeupBrands.Find(id);
            return makeupBrand;
        }

        public static List<int> getAllMakeupBrandID()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandID).ToList();
        }
        public static int getLastMakeupBrandID()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandID).ToList().LastOrDefault();
        }
        public static int generateMakeupBrandID()
        {
            int lastID = getLastMakeupBrandID();

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
        public static void insertMakeupBrand(String name, int rating)
        {
            int MakeupBrandID = generateMakeupBrandID();
            MakeupBrand Brand = MakeupBrandFactory.Create(MakeupBrandID, name, rating);
            db.MakeupBrands.Add(Brand);
            db.SaveChanges();
        }

        public static void updateMakeupBrand(int id, String name, int rating)
        {
            MakeupBrand updateBrand = db.MakeupBrands.Find(id);
            updateBrand.MakeupBrandName = name;
            updateBrand.MakeupBrandRating = rating;

            db.SaveChanges();
        }
    }
}