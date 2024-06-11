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
    public partial class ManageMakeup : System.Web.UI.Page
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
                    if (user.UserRole == "Admin")
                    {
                        List<Makeup> makeupList = MakeupController.getAllMakeups();
                        MangeMakeup.DataSource = makeupList;
                        MangeMakeup.DataBind();

                        List<MakeupType> makeupTypeList = MakeupTypeController.getAllMakeupTypes();
                        MakeupTypeGV.DataSource = makeupTypeList;
                        MakeupTypeGV.DataBind();

                        List<MakeupBrand> makeupBrandList = MakeupBrandController.getAllMakeupBrands();
                        MakeupBrandGV.DataSource = makeupBrandList;
                        MakeupBrandGV.DataBind();
                    }
                    else
                    {
                        Response.Redirect("~/Views/Home.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        protected void MangeMakeup_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MangeMakeup.Rows[e.RowIndex];
            String name = row.Cells[0].Text;
            int id = MakeupController.getMakeupIDByName(name);
            MakeupController.RemoveMakeupById(id);
            List<Makeup> makeupList = MakeupController.getAllMakeups();
            MangeMakeup.DataSource = makeupList;
            MangeMakeup.DataBind();
        }

        protected void MangeMakeup_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MangeMakeup.Rows[e.NewEditIndex];
            String nameAwal = row.Cells[0].Text;

            //harus diginiin karena di kalo namenya ada petiknya dia returnnya malah gajelas
            String name = HttpUtility.HtmlDecode(nameAwal);
            //System.Diagnostics.Debug.WriteLine("Editing makeup with name: " + name);

            int id = MakeupController.getMakeupIDByName(name);
            Response.Redirect("~/Views/UpdateMakeup.aspx?id=" + id);
        }

        protected void InsertMakeupBtnBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeup.aspx");
        }

        protected void MakeupTypeGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Kalo kita hapus typeID 1, beraarti makeup yang punya id 1 juga ikut kehapus
            GridViewRow row = MakeupTypeGV.Rows[e.RowIndex];
            String name = row.Cells[0].Text;
            int id = MakeupTypeController.getMakeupTypeIDByName(name);
            MakeupTypeController.RemoveMakeupTypeById(id);
            List<MakeupType> makeupTypeList = MakeupTypeController.getAllMakeupTypes();
            MakeupTypeGV.DataSource = makeupTypeList;
            MakeupTypeGV.DataBind();

            List<Makeup> makeupList = MakeupController.getAllMakeups();
            MangeMakeup.DataSource = makeupList;
            MangeMakeup.DataBind();
        }

        protected void MakeupTypeGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupTypeGV.Rows[e.NewEditIndex];
            String name = row.Cells[0].Text;
            int id = MakeupTypeController.getMakeupTypeIDByName(name);
            Response.Redirect("~/Views/UpdateMakeupType.aspx?id=" + id);
        }

        protected void InsertTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeupType.aspx");
        }

        protected void MakeupBrandGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MakeupBrandGV.Rows[e.RowIndex];
            String name = row.Cells[0].Text;
            int id = MakeupBrandController.getMakeupBrandIDByName(name);
            MakeupBrandController.RemoveMakeupBrandById(id);
            List<MakeupBrand> makeupBrandList = MakeupBrandController.getAllMakeupBrands();
            MakeupBrandGV.DataSource = makeupBrandList;
            MakeupBrandGV.DataBind();

            List<Makeup> makeupList = MakeupController.getAllMakeups();
            MangeMakeup.DataSource = makeupList;
            MangeMakeup.DataBind();
        }

        protected void MakeupBrandGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupBrandGV.Rows[e.NewEditIndex];
            String name = row.Cells[0].Text;
            int id = MakeupBrandController.getMakeupBrandIDByName(name);
            Response.Redirect("~/Views/UpdateMakeupBrand.aspx?id=" + id);
        }

        protected void InsertBrandBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeupBrand.aspx");
        }
    }
}