using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Factories
{
    public class MakeupFactory
    {
        public static Makeup Create(int id, String name, int price, int weight, int makeupTypeID, int makeupBrandID)
        {
            Makeup makeup = new Makeup();
            makeup.MakeupID = id;
            makeup.MakeupName = name;
            makeup.MakeupPrice = price;
            makeup.MakeupWeight = weight;
            makeup.MakeupTypeID = makeupTypeID;
            makeup.MakeupBrandID = makeupBrandID;
            return makeup;
        }
    }
}