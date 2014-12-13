using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_manager : System.Web.UI.Page
{
    public static string sr;
    public static bool myflag = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Manager"] == null || Request.Cookies["Manager"].Value.Length == 0)
        {
            Response.Redirect("\\LoginPage.apsx");
        }
        lblWelcome.Text = lblWelcome.Text + Session["user"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] arr = { "BOOK1", "BOOK2", "BOOK3", "BOOK4", "BOOK5", "BOOK6", "BOOK7", "BOOK8", };
        Random r = new Random();
        string s = arr[r.Next(0, arr.Length)];
        sr = "DEAL OF THE DAY is " + s + "...!!!!!!!!!!!";
        myflag = true;
    }
    public string dealoftheday()
    {
        if (!myflag)
            return "DEAL OF THE DAY IS NOT YET GENERATED.. !!!!!!";
        else
            return sr;
    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Logout.aspx");
    }
}