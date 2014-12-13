using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;
using System.Reflection;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

           //Clearing cookies and session while logging out
            Response.Cookies["AdminUser"].Value = null;

            Response.Cookies["Manager"].Value = null;

            Response.Cookies["Staff"].Value = null;

            Response.Cookies["Member"].Value = null;

            Session["user"] = null;
            
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultPage.aspx");
    }
}