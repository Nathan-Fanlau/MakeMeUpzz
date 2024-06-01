using MakeUpzz.Controller;
using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeUpzz.Views
{
    public partial class OrderMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {          
            if (!IsPostBack)
            {
                User user = (User)Session["user"];
                if (user == null && Request.Cookies["user_cookies"] != null)
                {
                    // Mendapatkan user berdasarkan cookies
                    string username = Request.Cookies["user_cookies"].Value;
                    user = UserController.getUserByName(username);
                    Session["user"] = user;
                }

                if (user != null)
                {
                    if (user.UserRole == "Customer")
                    {
                        List<Makeup> makeupList = MakeupController.getAllMakeups();
                        MakeupGV.DataSource = makeupList;
                        MakeupGV.DataBind();
                    }
                    else
                    {
                        MakeupGV.Visible = false;
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        protected void OrderButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int makeupId = int.Parse(btn.CommandArgument);
            TextBox txtQuantity = (TextBox)btn.NamingContainer.FindControl("quantityTB");
            int quantity = int.Parse(txtQuantity.Text);

            if (quantity > 0)
            {
                User user = (User)Session["user"];
                CartController.addToCart(user.UserID, makeupId, quantity);
                MessageLabel.Text = "Item added to cart.";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageLabel.Text = "Quantity must be greater than 0.";
                MessageLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void ClearCartButton_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            CartController.clearCart(user.UserID);
            MessageLabel.Text = "Cart cleared.";
            MessageLabel.ForeColor = System.Drawing.Color.Green;
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            CartController.checkout(user.UserID);
            MessageLabel.Text = "Checkout successful.";
            MessageLabel.ForeColor = System.Drawing.Color.Green;
        }
    }
}