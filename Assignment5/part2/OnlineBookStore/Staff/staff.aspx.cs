using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Web;
using System.Xml.Xsl;
using System.Net;

public partial class Staff_staff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Staff"] == null || Request.Cookies["Staff"].Value.Length == 0)
        {
            Response.Redirect("\\LoginPage.apsx");
        }
        if(!IsPostBack)
        lblWelcome.Text = lblWelcome.Text + Session["user"];
        try
        {
            String xmlfilePath = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data", "TextFile1.xml");
            String xslfilePath = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data", "TextFile1.xsl");
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string book_id = DropDownList1.SelectedItem.Text;
        string book_name = DropDownList1.SelectedItem.Text;
        int value = Convert.ToInt32(DropDownList1.SelectedItem.Value);

        String filePath = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data", "TextFile1.xml");

        string returnString = "";
        if (!File.Exists(filePath))
        {
            returnString = "Database Error!!";
        }
        else
        {
            try
            {
                XmlDocument xd = new XmlDocument();
                xd.Load(filePath);
                XPathDocument document = new XPathDocument(filePath);
                XPathNavigator navigator = document.CreateNavigator();
                navigator.MoveToChild("listofbooks", "");
                XmlElement bookId = xd.SelectSingleNode(String.Format("//book[@bookId='{0}']", book_id)) as XmlElement;
                if (bookId != null)
                {

                    //returnString = "bookId already exists. just increase the quantity";

                    bookId.SelectSingleNode("//quantity").InnerText = (Convert.ToInt32(bookId.SelectSingleNode("//quantity").InnerText) + Convert.ToInt32(TextBox1.Text)).ToString();
                    xd.Save(filePath);


                }
                else
                {
                    XmlElement dataElement = xd.SelectSingleNode(String.Format("//listofbooks", "")) as XmlElement;
                    XmlElement userElement = xd.CreateElement("book");
                    userElement.SetAttribute("bookId", "", book_id);
                    dataElement.AppendChild(userElement);



                    navigator.MoveToChild("listofbooks", "");
                    bookId = xd.SelectSingleNode(String.Format("//book[@bookId='{0}']", book_id)) as XmlElement;
                    XmlElement name = xd.CreateElement("name");
                    name.InnerText = book_name;
                    bookId.AppendChild(name);
                    XmlElement my_value = xd.CreateElement("value");
                    my_value.InnerText = value.ToString();
                    bookId.AppendChild(my_value);
                    XmlElement quantity = xd.CreateElement("quantity");
                    quantity.InnerText = TextBox1.Text;
                    bookId.AppendChild(quantity);
                    xd.Save(filePath);
                }

            }
            catch (Exception exception)
            {
                returnString = "Database Error" + exception.Message;
            }
            Console.Write(returnString);


            
        }
     

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
  
    protected void Button2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("/Logout.aspx");
    }
}