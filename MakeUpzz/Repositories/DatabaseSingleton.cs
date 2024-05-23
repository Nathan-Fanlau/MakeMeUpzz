using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class DatabaseSingleton
    {
        private static MakeupzzDatabaseEntities db = null;
        public static MakeupzzDatabaseEntities GetInstance()
        {
            if (db == null)
            {
                db = new MakeupzzDatabaseEntities();
            }
            return db;
        }
    }
}