using MakeUpzz.Controller;
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
    public partial class InsertMakeup : System.Web.UI.Page
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
                        Response.Redirect("~/Views/Home.aspx");
                    }
                    else
                    {
                        MakeUpTypeDD.DataSource = MakeupTypeController.getAllMakeupTypeID();
                        MakeUpTypeDD.DataBind();

                        MakeUpBrandDD.DataSource = MakeupBrandController.getAllMakeupBrandID();
                        MakeUpBrandDD.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            String MakeUpName = NameTB.Text;
            int MakeUpPrice = int.Parse(PriceTB.Text);
            int MakeUpWeight = int.Parse(WeightTB.Text);
            int MakeUpTypeID = int.Parse(MakeUpTypeDD.SelectedValue);
            int MakeUpBrandId = int.Parse(MakeUpBrandDD.SelectedValue);
            string errorMsg = MakeupController.registMakeup(MakeUpName, MakeUpPrice, MakeUpWeight, MakeUpTypeID, MakeUpBrandId);

            if (errorMsg == "Insert Makeup Successful!")
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                MakeupController.insertMakeup(MakeUpName, MakeUpPrice, MakeUpWeight, MakeUpTypeID, MakeUpBrandId);
            }
            else
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}