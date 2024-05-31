using MakeUpzz.Models;
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
    }
}