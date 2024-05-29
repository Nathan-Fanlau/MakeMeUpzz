using MakeUpzz.Factories;
using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Handler
{
    public class CartHandler
    {
        public static void addToCart(int userID, int makeupID, int quantity)
        {
            CartRepository.addToCart(userID, makeupID, quantity);
        }

        public static void clearCart(int userID)
        {
            CartRepository.clearCart(userID);
        }

        public static void checkout(int userID)
        {
            CartRepository.checkout(userID);
        }
    }
}