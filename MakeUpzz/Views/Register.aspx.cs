using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeUpzz.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            String errorMessage = "";
            String username = nameTB.Text;
            String email = emailTB.Text;
            String gender = genderList.SelectedValue;
            String password = passwordTB.Text;
            String confirmPassword = confirmTB.Text;
            DateTime DOB = dobCalendar.SelectedDate;

            UserRepository userRepo = new UserRepository();

            //Username Validation
            if (string.IsNullOrEmpty(username))
            {
                errorMessage += "Username cannot be empty <br/>";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                errorMessage += "Username length must be between 5 and 15 character <br/>";
            }
            else if (!userRepo.IsUsernameUnique(username))
            {
                errorMessage += "Username must be unique <br/>";
            }

            //Email Validation
            if (string.IsNullOrEmpty(email))
            {
                errorMessage += "Email cannot be empty.<br/>";
            }
            else if (!(email.EndsWith(".com")))
            {
                errorMessage += "Email must ends with ‘.com’ <br/>";
            }

            //Gender Validation
            if (gender == "")
            {
                errorMessage += "Gender Must be chosen and cannot be empty <br/>";
            }

            //Password  and Confirm Password Validation
            if (string.IsNullOrEmpty(password))
            {
                errorMessage += "Password cannot be empty <br/>";
            }
            if (string.IsNullOrEmpty(confirmPassword))
            {
                errorMessage += "Confirm password cannot be empty <br/>";
            }
            else if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                errorMessage += "Password must be alphanumeric.<br/>";
            }
            else if (password != confirmPassword)
            {
                errorMessage += "Must be the same with confirm password <br/>";
            }

            System.Diagnostics.Debug.WriteLine($"Password: {password}");
            System.Diagnostics.Debug.WriteLine($"Confirm Password: {confirmPassword}");


            //DOB Validation
            if (DOB == DateTime.MinValue)
            {
                errorMessage += "Date of Birth cannot be empty.<br/>";
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                ErrorLbl.Text = errorMessage;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ErrorLbl.Text = "Register Successful!";
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}