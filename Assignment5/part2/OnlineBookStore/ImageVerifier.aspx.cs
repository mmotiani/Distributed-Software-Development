using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;


public partial class ImageVerifier : System.Web.UI.Page
{
    static string s;
    Random rnd = new Random();
    XmlDocument woeidData = new XmlDocument();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int n = 5;
            //Service for getting the verifier string
            woeidData.Load(String.Format("http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetVerifierString/{0}", n));
            s = woeidData.GetElementsByTagName("string")[0].InnerText;
            //Calling service for getting verifier image
            Image1.ImageUrl = String.Format("http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc//GetImage/{0}", s);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (s == TextBox1.Text)
        {
            Response.Redirect("NewUserRegistration.aspx");
        }
        else
        {
            Response.Redirect("ImageVerifier.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}