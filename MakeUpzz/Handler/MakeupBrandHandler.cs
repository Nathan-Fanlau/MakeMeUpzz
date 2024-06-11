using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Handler
{
    public class MakeupBrandHandler
    {
        public static List<MakeupBrand> getAllMakeupBrands()
        {
            return MakeupBrandRepository.getAllMakeupBrands();
        }

        public static int getMakeupBrandIDByName(String name)
        {
            return MakeupBrandRepository.getMakeupBrandIDByName(name);
        }

        public static void RemoveMakeupBrandById(int id)
        {
            MakeupBrandRepository.RemoveMakeupBrandById(id);
        }

        public static MakeupBrand GetMakeupBrandByID(int id)
        {
            return MakeupBrandRepository.GetMakeupBrandByID(id);
        }
        public static List<int> getAllMakeupBrandID()
        {
            return MakeupBrandRepository.getAllMakeupBrandID();
        }

        public static void insertMakeupBrand(String name, int rating)
        {
            MakeupBrandRepository.insertMakeupBrand(name, rating);
        }

        public static void updateMakeupBrand(int id, String name, int rating)
        {
            MakeupBrandRepository.updateMakeupBrand(id, name, rating);
        }
    }
}