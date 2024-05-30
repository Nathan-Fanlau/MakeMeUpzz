using MakeUpzz.Handler;
using MakeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeUpzz.Views
{
    public partial class TransactionDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                User user = (User)Session["user"];
                if (user == null && Request.Cookies["user_cookies"] != null)
                {
                    // Mendapatkan user berdasarkan cookies
                    string username = Request.Cookies["user_cookies"].Value;
                    user = UserHandler.getUserByName(username);
                    Session["user"] = user;
                }
                if (user != null)
                {
                    int TransactionID = Convert.ToInt32(Request.QueryString["id"]);
                    List<TransactionDetail> listTD = TransactionDetailHandler.getTransactionDetailByID(TransactionID);
                    TransactionDetailGV.DataSource = listTD;
                    TransactionDetailGV.DataBind();
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }
    }
}