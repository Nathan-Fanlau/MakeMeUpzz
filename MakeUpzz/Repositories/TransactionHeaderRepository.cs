using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class TransactionHeaderRepository
    {
        MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public int getLastTransactionID()
        {
            return (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
        }
    }
}