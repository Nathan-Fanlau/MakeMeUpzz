using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int tranID, int makeupID, int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = tranID;
            td.MakeupID = makeupID;
            td.Quantity = quantity;
            return td;
        }
    }
}