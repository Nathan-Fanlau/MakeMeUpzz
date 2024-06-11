using MakeUpzz.Handler;
using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Controller
{
    public class MakeupBrandController
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

        public static string ValidateRating(int rating)
        {
            string lbl = "";
         
            if (rating < 0 || rating > 100)
            {
                lbl = "Rating must be between 0 - 100 <br/>";
            }

            return lbl;
        }

        public static string registMakeupBrand(string name, int rating)
        {
            string lbl = "";
            lbl += ValidateName(name);
            lbl += ValidateRating(rating);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Insert MakeupBrand Successful!";
        }

        public static string validateUpdate(string name, int rating)
        {
            string lbl = "";
            lbl += ValidateName(name);
            lbl += ValidateRating(rating);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Update Successful!";
        }

        public static void insertMakeupBrand(String name, int rating)
        {
            MakeupBrandHandler.insertMakeupBrand(name, rating);
        }

        public static void updateMakeupBrand(int id, String name , int rating)
        {
            MakeupBrandHandler.updateMakeupBrand(id, name, rating);
        }
        public static List<MakeupBrand> getAllMakeupBrands()
        {
            return MakeupBrandHandler.getAllMakeupBrands();
        }

        public static int getMakeupBrandIDByName(String name)
        {
            return MakeupBrandHandler.getMakeupBrandIDByName(name);
        }

        public static void RemoveMakeupBrandById(int id)
        {
            MakeupBrandHandler.RemoveMakeupBrandById(id);
        }

        public static MakeupBrand GetMakeupBrandByID(int id)
        {
            return MakeupBrandHandler.GetMakeupBrandByID(id);
        }
        public static List<int> getAllMakeupBrandID()
        {
            return MakeupBrandHandler.getAllMakeupBrandID();
        }
    }
}