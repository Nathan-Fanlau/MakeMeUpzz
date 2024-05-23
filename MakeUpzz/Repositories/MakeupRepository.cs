using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class MakeupRepository
    {
        MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<Makeup> getAllMakeups()
        {
            return (from x in db.Makeups select x).ToList();
        }
    }
}