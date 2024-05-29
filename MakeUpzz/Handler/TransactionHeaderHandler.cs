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
    }
}