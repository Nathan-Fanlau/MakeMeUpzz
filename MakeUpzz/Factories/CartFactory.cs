using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Factories
{
    public class CartFactory
    {
        public static Cart Create(int cartID, int userID, int makeupID, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = cartID;
            cart.UserID = userID;
            cart.MakeupID = makeupID;
            cart.Quantity = quantity;
            return cart;
        }
    }
}