using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Handler
{
    public class TransactionDetailHandler
    {
        public static List<TransactionDetail> getTransactionDetailByID(int ID)
        {
            return TransactionDetailRepository.getTransactionDetailByID(ID);
        }

        public static List<TransactionDetail> getTransactionDetailByMakeupID(int ID)
        {
            return TransactionDetailRepository.getTransactionDetailByMakeupID(ID);
        }
    }
}