using MakeUpzz.Handler;
using MakeUpzz.Models;
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
    }
}