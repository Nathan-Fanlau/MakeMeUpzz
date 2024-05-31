using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Handler
{
    public class MakeupHandler
    {
        public static List<Makeup> getAllMakeups()
        {
            return MakeupRepository.getAllMakeups();
        }

        public static int getMakeupPrice(int id)
        {
            return MakeupRepository.getMakeupPrice(id);
        }
    }
}