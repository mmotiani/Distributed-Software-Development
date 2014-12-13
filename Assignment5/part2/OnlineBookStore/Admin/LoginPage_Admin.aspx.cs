using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Security.Policy;
using System.IO;
using System.Xml.XmlConfiguration;


public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "TA" && TextBox2.Text == "CSE445598ta!")
        {
            Response.Cookies["AdminUser"].Value = TextBox1.Text;
            Response.Redirect("~/Admin/AdminHomePage.aspx");
        }
        else
        {
            Label1.Text = "Invalid username or password!! Reload the Page";
        }
    }
   
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}