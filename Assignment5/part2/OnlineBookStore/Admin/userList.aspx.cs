using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;


public partial class userList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["AdminUser"].Value == null || Request.Cookies["AdminUser"].Value.Length == 0)
        {
            Response.Redirect("/LoginPage.apsx");
        }
        try
        {
            String xmlfilePath = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data", "UserInfo.xml");
            String xslfilePath = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data", "UserInfo.xsl");
            WebClient wb = new WebClient(); //creating object of web client
            string str = null;
            string html = null;
            string str1 = null;
            XslCompiledTransform xslt = new XslCompiledTransform();  //creating object of XslCompiledTransform
            xslt.Load(xslfilePath); //loading XSL document to XslCompiledTransform object
            str1 = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data");
            html = Path.Combine(str1, "Document.html"); //storing HTML to the server.
            xslt.Transform(xmlfilePath, html); //saving generated HTML document
            str = wb.DownloadString(html);
            Label1.Text = str;
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
    
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("AdminHomePage.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("/Logout.aspx");
    }
}