using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Factories
{
    public class MakeupTypeFactory
    {
        public static MakeupType Create(int typeID, String name)
        {
            MakeupType type = new MakeupType();
            type.MakeupTypeID = typeID;
            type.MakeupTypeName = name;
            return type;
        }
    }
}