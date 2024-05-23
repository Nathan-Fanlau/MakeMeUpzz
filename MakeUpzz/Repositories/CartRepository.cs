using MakeUpzz.Factories;
using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Repositories
{
    public class CartRepository
    {
        MakeupzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        public int getLastCartID()
        {
            return (from x in db.Carts select x.CartID).ToList().LastOrDefault();
        }

        public void addToCart(int cartID, int userID, int makeupID, int quantity)
        {
            Cart cart = CartFactory.Create(cartID, userID, makeupID, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public void clearCart(int userID)
        {
            //Cart cart = db.Carts.Find(userID);
            List<Cart> cartItems = db.Carts.Where(c => c.UserID == userID).ToList();
            db.Carts.RemoveRange(cartItems);
            db.SaveChanges();
        }

        public int generateTransactionID()
        {
            TransactionHeaderRepository thRepo = new TransactionHeaderRepository();
            int lastID = thRepo.getLastTransactionID();

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

        public void checkout(int userID)
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
                    TransactionDetail existingTD = db.TransactionDetails
                        .FirstOrDefault(td => td.TransactionID == th.TransactionID && td.MakeupID == cart.MakeupID);

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