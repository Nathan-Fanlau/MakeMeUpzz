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
        public static string ValidateName(string username)
        {
            string lbl = "";
            if (string.IsNullOrEmpty(username))
            {
                lbl = "Username cannot be empty  <br/>";
            }
            else if (username.Length < 1 || username.Length > 99)
            {
                lbl = "Username length must be between 1 - 99 characters <br/>";
            }

            return lbl;
        }

        public static string ValidatePrice(int price)
        {
            string lbl = "";

            if (price<1)
            {
                lbl = "Price must be greater than or equals than 1  <br/>";
            }

            return lbl;
        }

        public static string ValidateWeight(int weight)
        {
            string lbl = "";

            if (weight > 1500)
            {
                lbl = "Weight cannot be greater than 1500 since it is in grams  <br/>";
            }

            return lbl;
        }

        public static string ValidateTypeID(int Typeid)
        {
            string lbl = "";
            if (Typeid == 0 || Typeid == null)
            {
                lbl = "TypeID cannot be empty <br/>";
            }

            return lbl;
        }

        public static string ValidateBrandID(int Brandid)
        {
            string lbl = "";
            if (Brandid == 0 || Brandid == null)
            {
                lbl = "BrandID cannot be empty <br/>";
            }

            return lbl;
        }

        public static string validateUpdate(string name, int price, int weight, int typeID, int brandID)
        {
            string lbl = "";
            lbl += ValidateName(name);
            lbl += ValidatePrice(price);
            lbl += ValidateWeight(weight);
            lbl += ValidateTypeID(typeID);
            lbl += ValidateBrandID(brandID);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Update Successful!";
        }

        public static string registMakeup(string name, int price, int weight, int typeID, int brandID)
        {
            string lbl = "";
            lbl += ValidateName(name);
            lbl += ValidatePrice(price);
            lbl += ValidateWeight(weight);
            lbl += ValidateTypeID(typeID);
            lbl += ValidateBrandID(brandID);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Insert Makeup Successful!";
        }

        public static List<Makeup> getAllMakeups()
        {
            return MakeupHandler.getAllMakeups();
        }

        public static int getMakeupPrice(int id)
        {
            return MakeupHandler.getMakeupPrice(id);
        }

        public static int getMakeupIDByName(String name)
        {
            return MakeupHandler.getMakeupIDByName(name);
        }

        public static void RemoveMakeupById(int id)
        {
            MakeupHandler.RemoveMakeupById(id);
        }

        public static Makeup GetMakeupByID(int id)
        {
            return MakeupHandler.GetMakeupByID(id);
        }

        public static List<Makeup> GetMakeupByTypeID(int typeID)
        {
            return MakeupHandler.GetMakeupByTypeID(typeID);
        }

        public static List<Makeup> GetMakeupByBrandID(int brandID)
        {
            return MakeupHandler.GetMakeupByBrandID(brandID);
        }

        public static void UpdateMakeupByID(int id, String name, int price, int weight, int makeupTypeID, int makeupBrandID)
        {
            MakeupHandler.UpdateMakeupByID(id, name, price, weight, makeupTypeID, makeupBrandID);
        }
        public static void insertMakeup(String name, int price, int weight, int typeID, int brandID)
        {
            MakeupHandler.insertMakeup(name, price, weight, typeID, brandID);
        }
    }
}