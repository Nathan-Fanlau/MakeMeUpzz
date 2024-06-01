using MakeUpzz.Handler;
using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Controller
{
    public class MakeupController
    {
        public static List<Makeup> getAllMakeups()
        {
            return MakeupHandler.getAllMakeups();
        }

        public static int getMakeupPrice(int id)
        {
            return MakeupHandler.getMakeupPrice(id);
        }
    }
}