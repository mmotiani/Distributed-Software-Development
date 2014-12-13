using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //To check if user is an admin and if not redirects to the Login Page
        if (Request.Cookies["AdminUser"].Value == null || Request.Cookies["AdminUser"].Value.Length == 0)
        {
            Response.Redirect("\\LoginPage.apsx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("userList.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistrationPage.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        
        Response.Redirect("~/Logout.aspx");
    }
}