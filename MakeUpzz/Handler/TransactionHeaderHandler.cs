using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Handler
{
    public class TransactionHeaderHandler
    {
        public static int getLastTransactionID()
        {
            return TransactionHeaderRepository.getLastTransactionID();
        }

        public static List<TransactionHeader> getAllTransactionHeaderByUserID(int UserID)
        {
            return TransactionHeaderRepository.getAllTransactionHeaderByUserID(UserID);
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return TransactionHeaderRepository.getAllTransactionHeader();
        }

        public static void handleTransaction(int TransactionID)
        {
            TransactionHeaderRepository.handleTransaction(TransactionID);
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            return TransactionHeaderRepository.getAllTransaction();
        }
    }
}