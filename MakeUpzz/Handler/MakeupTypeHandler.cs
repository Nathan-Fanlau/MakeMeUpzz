using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Handler
{
    public class MakeupTypeHandler
    {
        public static List<MakeupType> getAllMakeupTypes()
        {
            return MakeupTypeRepository.getAllMakeupTypes();
        }

        public static int getMakeupTypeIDByName(String name)
        {
            return MakeupTypeRepository.getMakeupTypeIDByName(name);
        }

        public static void RemoveMakeupTypeById(int id)
        {
            MakeupTypeRepository.RemoveMakeupTypeById(id);
        }

        public static MakeupType GetMakeupTypeByID(int id)
        {
            return MakeupTypeRepository.GetMakeupTypeByID(id);
        }

        public static List<int> getAllMakeupTypeID()
        {
            return MakeupTypeRepository.getAllMakeupTypeID();
        }

        public static void insertMakeupType(String name)
        {
            MakeupTypeRepository.insertMakeupType(name);
        }

        public static void updateMakeupType(int id, String name)
        {
            MakeupTypeRepository.updateMakeupType(id, name);
        }

    }
}