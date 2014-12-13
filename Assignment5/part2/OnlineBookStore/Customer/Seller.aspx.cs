using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_Seller : System.Web.UI.Page
{
    string catalogkey;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Member"] == null)
        {
            Response.Redirect("/LoginPage.apsx");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        string bookTitle = txtTitle.Text;

        string num = Convert.ToString(Session.Count + 1);
        catalogkey = "sBook" + num;
        //Storing the book in session variable
        Session[catalogkey] = bookTitle;
        Response.Redirect("Catalog.aspx");
    }
}