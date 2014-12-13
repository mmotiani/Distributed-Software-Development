using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
		if ((myCookies == null) || (myCookies["Name"]=="")) {
          	Label3.Text = "Welcome, new user";
	} else {
		Label3.Text = "Welcome, " + myCookies["Name"];
		Label4.Text = "We have your email " + myCookies["Email"];
		}	
	}

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = new HttpCookie("myCookieId");
		  myCookies["Name"] = TextBox1.Text;
            myCookies["Email"] = TextBox2.Text;
            myCookies.Expires = DateTime.Now.AddMonths(6);
            Response.Cookies.Add(myCookies);
            Label3.Text = "Name stored in Cookie " + myCookies["Name"];
            Label4.Text = "Email stored in Cookie " + myCookies["Email"];        
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        }
    
}