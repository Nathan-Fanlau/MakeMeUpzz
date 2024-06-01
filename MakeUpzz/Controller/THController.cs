using MakeUpzz.Handler;
using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Controller
{
    public class THController
    {
        public static int getLastTransactionID()
        {
            return TransactionHeaderHandler.getLastTransactionID();
        }

        public static List<TransactionHeader> getAllTransactionHeaderByUserID(int UserID)
        {
            return TransactionHeaderHandler.getAllTransactionHeaderByUserID(UserID);
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return TransactionHeaderHandler.getAllTransactionHeader();
        }

        public static void handleTransaction(int TransactionID)
        {
            TransactionHeaderHandler.handleTransaction(TransactionID);
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            return TransactionHeaderHandler.getAllTransaction();
        }
    }
}