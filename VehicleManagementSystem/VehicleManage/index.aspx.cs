using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VehicleManagementSystem;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void LogIn(object sender, EventArgs e)
    {
        if (IsValid)
        {
            // Validate the user password
            // Create a new user
            var manager = new UserManager();
            ApplicationUser user = manager.Find(UserName.Text, Password.Text);
            if (user != null)
            {
                IdentityHelper.SignIn(manager, user, false);
                IdentityHelper.RedirectToReturnUrl("~/VehicleManagementSystem/HomePage.aspx", Response);
            }
            else
            {
                FailureText.Text = "帐号或密码错误，请重新输入";
                ErrorMessage.Visible = true;
            }
        }
    }
}