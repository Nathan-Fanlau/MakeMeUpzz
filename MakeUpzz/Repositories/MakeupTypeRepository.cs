using MakeUpzz.Factories;
using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class MakeupTypeRepository
    {
        private static MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<MakeupType> getAllMakeupTypes()
        {
            return (from x in db.MakeupTypes select x).ToList();
        }

        public static int getMakeupTypeIDByName(String name)
        {
            return (from x in db.MakeupTypes where x.MakeupTypeName == name select x.MakeupTypeID).FirstOrDefault();
        }

        public static void RemoveMakeupTypeById(int id)
        {
            //Kalo kita hapus typeID 1, beraarti makeup yang punya id 1 juga ikut kehapus
            MakeupType makeupType = db.MakeupTypes.Find(id);
            List<Makeup> makeup = MakeupRepository.GetMakeupByTypeID(id);
            db.Makeups.RemoveRange(makeup);
            db.MakeupTypes.Remove(makeupType);
            db.SaveChanges();
        }

        public static MakeupType GetMakeupTypeByID(int id)
        {
            MakeupType makeupType = db.MakeupTypes.Find(id);
            return makeupType;
        }

        public static List<int> getAllMakeupTypeID()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeID).ToList();
        }

        public static int getLastMakeupTypeID()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeID).ToList().LastOrDefault();
        }
        public static int generateMakeupTypeID()
        {
            int lastID = getLastMakeupTypeID();

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

        public static void insertMakeupType(String name)
        {
            int MakeupTypeID = generateMakeupTypeID();
            MakeupType type = MakeupTypeFactory.Create(MakeupTypeID, name);
            db.MakeupTypes.Add(type);
            db.SaveChanges();
        }

        public static void updateMakeupType(int id, String name)
        {
            MakeupType updateType = db.MakeupTypes.Find(id);
            updateType.MakeupTypeName = name;

            db.SaveChanges();
        }
    }
}