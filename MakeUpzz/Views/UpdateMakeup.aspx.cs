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
    public partial class UpdateMakeup : System.Web.UI.Page
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
                        int Id = int.Parse(Request.QueryString["id"]);
                        Makeup makeup = MakeupController.GetMakeupByID(Id);
                        NameTB.Text = makeup.MakeupName;
                        PriceTB.Text = makeup.MakeupPrice.ToString();
                        WeightTB.Text = makeup.MakeupWeight.ToString();
                        MakeUpTypeDD.DataSource = MakeupTypeController.getAllMakeupTypeID();
                        MakeUpTypeDD.DataBind();

                        MakeUpBrandDD.DataSource = MakeupBrandController.getAllMakeupBrandID();
                        MakeUpBrandDD.DataBind();

                        MakeUpTypeDD.SelectedValue = makeup.MakeupTypeID.ToString();
                        MakeUpBrandDD.SelectedValue = makeup.MakeupBrandID.ToString();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(Request.QueryString["id"]);
            String MakeUpName = NameTB.Text;
            int MakeUpPrice = int.Parse(PriceTB.Text);
            int MakeUpWeight = int.Parse(WeightTB.Text);
            int MakeUpTypeID = int.Parse(MakeUpTypeDD.SelectedValue);
            int MakeUpBrandId = int.Parse(MakeUpBrandDD.SelectedValue);
            string errorMsg = MakeupController.validateUpdate(MakeUpName, MakeUpPrice, MakeUpWeight, MakeUpTypeID, MakeUpBrandId);
            if (errorMsg == "Update Successful!")
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                MakeupController.UpdateMakeupByID(updateID, MakeUpName, MakeUpPrice, MakeUpWeight, MakeUpTypeID, MakeUpBrandId);
            }
            else
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}