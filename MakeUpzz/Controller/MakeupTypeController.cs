using MakeUpzz.Handler;
using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Controller
{
    public class MakeupTypeController
    {
        public static List<MakeupType> getAllMakeupTypes()
        {
            return MakeupTypeHandler.getAllMakeupTypes();
        }

        public static int getMakeupTypeIDByName(String name)
        {
            return MakeupTypeHandler.getMakeupTypeIDByName(name);
        }

        public static void RemoveMakeupTypeById(int id)
        {
            MakeupTypeHandler.RemoveMakeupTypeById(id);
        }

        public static MakeupType GetMakeupTypeByID(int id)
        {
            return MakeupTypeHandler.GetMakeupTypeByID(id);
        }
        public static List<int> getAllMakeupTypeID()
        {
            return MakeupTypeHandler.getAllMakeupTypeID();
        }

        public static string ValidateName(string username)
        {
            string lbl = "";
            if (string.IsNullOrEmpty(username))
            {
                lbl = "Username cannot be empty  <br/>";
            }
            else if (username.Length < 1 || username.Length > 99)
            {
                lbl = "Username length must be between 1 and 99 characters <br/>";
            }

            return lbl;
        }


        public static string registMakeupType(string name)
        {
            string lbl = "";
            lbl += ValidateName(name);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Insert MakeupType Successful!";
        }

        public static string validateUpdate(string name)
        {
            string lbl = "";
            lbl += ValidateName(name);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Update MakeupType Successful!";
        }

        public static void insertMakeupType(String name)
        {
            MakeupTypeHandler.insertMakeupType(name);
        }

        public static void updateMakeupType(int id,String name)
        {
            MakeupTypeHandler.updateMakeupType(id, name);
        }
    }
}