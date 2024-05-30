using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MakeUpzz.Repositories
{
    public class TransactionDetailRepository
    {
        private static MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<TransactionDetail> getTransactionDetailByID(int ID)
        {
            return (from x in db.TransactionDetails where x.TransactionID == ID select x).ToList();
        }

    }
}