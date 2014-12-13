using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TimeTryIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox3.Text != TextBox4.Text)
        {
            Response.Redirect("http://webstrar5.fulton.asu.edu/page10/InvalidPage.aspx"); //Will redirect to the invalid page after unsuccessful registration
        }
        else
        {
            Response.Redirect("http://webstrar5.fulton.asu.edu/page10/HomePage.aspx"); //Will redirect to the Home page after successful registration
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        
    }
}