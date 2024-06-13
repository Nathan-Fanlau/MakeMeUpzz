using MakeUpzz.Factories;
using MakeUpzz.Handler;
using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class CartRepository
    {
        private static MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static int getLastCartID()
        {
            return (from x in db.Carts select x.CartID).ToList().LastOrDefault();
        }
        public static List<Cart> getCartByMakeupID(int ID)
        {
            return (from x in db.Carts where x.MakeupID == ID select x).ToList();
        }

        public static int generateCartID()
        {
            int lastID = getLastCartID();

            if (lastID == null)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }
            return lastID;
        }

        public static void addToCart(int userID, int makeupID, int quantity)
        {
            int cartID = generateCartID();
            Cart cart = CartFactory.Create(cartID, userID, makeupID, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static void clearCart(int userID)
        {
            //Cart cart = db.Carts.Find(userID);
            List<Cart> cartItems = db.Carts.Where(c => c.UserID == userID).ToList();
            db.Carts.RemoveRange(cartItems);
            db.SaveChanges();
        }

        public static int generateTransactionID()
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();
            int lastID = TransactionHeaderRepository.getLastTransactionID();

            if (lastID == null)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }
            return lastID;
        }

        public static void checkout(int userID)
        {
            //Ngambil semua cart si user, karena 1 user bisa punya banyak cart
            List<Cart> userCarts = db.Carts.Where(c => c.UserID == userID).ToList();

            //Masukin ke Transaction Header
            TransactionHeader th = TransactionFactory.Create(generateTransactionID(), userID, DateTime.Now, "Unhandled");
            db.TransactionHeaders.Add(th);
            db.SaveChanges();

            //Ini masukin semua item dari setiap cart ke Transaction Details
            foreach (var cart in userCarts)
            {
                // Cari makeup berdasarkan MakeupID
                Makeup makeup = db.Makeups.Find(cart.MakeupID);
                if (makeup != null)
                {
                    // Cari TransactionDetail yang sudah ada
                    //TransactionDetail existingTD = db.TransactionDetails
                    //    .FirstOrDefault(td => td.TransactionID == th.TransactionID && td.MakeupID == cart.MakeupID);
                    TransactionDetail existingTD = TransactionDetailRepository.getExistedTD(th.TransactionID, cart.MakeupID);

                    if (existingTD != null)
                    {
                        // Update quantity yang sudah ada
                        existingTD.Quantity += cart.Quantity;
                    }
                    else
                    {
                        // Buat TransactionDetail baru jika tidak ada duplikat
                        TransactionDetail td = TransactionDetailFactory.Create(th.TransactionID, makeup.MakeupID, cart.Quantity);
                        db.TransactionDetails.Add(td);
                    }
                }
            }
            //db.SaveChanges();
            db.Carts.RemoveRange(userCarts);
            db.SaveChanges();
        }
    }
}