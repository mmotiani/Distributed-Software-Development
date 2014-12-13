using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.IO;

public partial class Customer_Catalog : System.Web.UI.Page
{
    string catalogkey;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Member"] == null || Request.Cookies["Member"].Value.Length == 0)
        {
            Response.Redirect("\\LoginPage.apsx");
        }
        if (Session["User"] != null)
        {
            lblWelcome.Text = lblWelcome.Text + Session["user"];
        }
        else
        {
            Response.Redirect("InvalidPage.aspx");
        }

        String filePath;
        if (!IsPostBack)
        {
            lstBooks.Items.Clear();
            //Below block of code is for fetching the list of books to be showed in the catalog from the database 
            filePath = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data", "TextFile1.xml");
            XmlTextReader reader = new XmlTextReader(filePath);
            for (; reader.Read(); )
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if ("book".Equals(reader.Name))
                    {

                        for (; reader.Read(); )
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                if ("name".Equals(reader.Name))
                                {
                                    lstBooks.Items.Add(reader.ReadString()); // Adding books to be shown in catalog
                                }
                            }
                        }
                    }
                }
            }



        }

    }

    protected void btnView_Click(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Seller.aspx");
    }
    protected void btnAddCart_Click(object sender, EventArgs e)
    {
        if (lstBooks.SelectedIndex < 0)
        {
            lblMessage.Text = "Please select a book from the list above";
        }
        else
        {
            string num = Convert.ToString(lstBooks.SelectedIndex + 1);
            string title = Convert.ToString(lstBooks.SelectedValue);
            catalogkey = "sBook" + num;
            // String book = Session[catalogkey].ToString(); ;
            Session["booktocart"] = title;
            Response.Redirect("Cart.aspx");

        }
    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Logout.aspx");
    }
}