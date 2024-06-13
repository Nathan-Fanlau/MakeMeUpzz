using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace MakeUpzz.Repositories
{
    public class TransactionDetailRepository
    {
        private static MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<TransactionDetail> getTransactionDetailByID(int ID)
        {
            return (from x in db.TransactionDetails where x.TransactionID == ID select x).ToList();
        }

        public static List<TransactionDetail> getTransactionDetailByMakeupID(int ID)
        {
            return (from x in db.TransactionDetails where x.MakeupID == ID select x).ToList();
        }

        public static TransactionDetail getExistedTD(int transactionID, int makeupID)
        {
            return db.TransactionDetails.FirstOrDefault(td => td.TransactionID == transactionID && td.MakeupID == makeupID);
        }
    }
}