using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeUpzz.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String errorMessage = "";
            String username = nameTB.Text;
            String password = passwordTB.Text;
            bool rememberMe = termsCB.Checked;
            UserRepository userRepo = new UserRepository();

            if (string.IsNullOrEmpty(username))
            {
                errorMessage += "Username cannot be empty <br/>";
            }

            if (string.IsNullOrEmpty(password))
            {
                errorMessage += "Password cannot be empty.<br/>";
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                ErrorLbl.Text = errorMessage;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }

            User user = userRepo.GetUserByNameAndPassword(username, password);


            if (user != null)
            {
                Session["user"] = user;
                if (rememberMe)
                {
                    HttpCookie cookie = new HttpCookie("user_cookies");
                    cookie.Value = user.Username;
                    cookie.Expires = DateTime.Now.AddHours(5);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/Views/Home.aspx");
            }
            else
            {
                errorMessage += "Invalid username or password.<br/>";
                ErrorLbl.Text = errorMessage;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}