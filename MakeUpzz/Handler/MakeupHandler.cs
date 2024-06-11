using MakeUpzz.Factories;
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
        public static int getMakeupIDByName(String name)
        {
            return MakeupRepository.getMakeupIDByName(name);
        }

        public static void RemoveMakeupById(int id)
        {
            MakeupRepository.RemoveMakeupById(id);
        }

        public static Makeup GetMakeupByID(int id)
        {
            return MakeupRepository.GetMakeupByID(id);
        }

        public static List<Makeup> GetMakeupByTypeID(int typeID)
        {
            return MakeupRepository.GetMakeupByTypeID(typeID);
        }

        public static List<Makeup> GetMakeupByBrandID(int brandID)
        {
            return MakeupRepository.GetMakeupByBrandID(brandID);
        }

        public static void UpdateMakeupByID(int id, String name, int price, int weight, int makeupTypeID, int makeupBrandID)
        {
            MakeupRepository.UpdateMakeupByID(id, name, price, weight, makeupTypeID, makeupBrandID);
        }
        public static void insertMakeup(String name, int price, int weight, int typeID, int brandID)
        {
            MakeupRepository.insertMakeup(name, price, weight, typeID, brandID);
        }
    }
}