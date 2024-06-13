using MakeUpzz.Handler;
using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Controller
{
    public class TDController
    {
        public static List<TransactionDetail> getTransactionDetailByID(int ID)
        {
            return TransactionDetailHandler.getTransactionDetailByID(ID);
        }

        public static List<TransactionDetail> getTransactionDetailByMakeupID(int ID)
        {
            return TransactionDetailHandler.getTransactionDetailByMakeupID(ID);
        }

        public static TransactionDetail getExistedTD(int transactionID, int makeupID)
        {
            return TransactionDetailHandler.getExistedTD(transactionID, makeupID);
        }
    }
}