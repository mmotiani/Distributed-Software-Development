using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_Cart : System.Web.UI.Page
{
    string catalogkey;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Member"] == null || Request.Cookies["Member"].Value.Length == 0)
        {
            Response.Redirect("\\LoginPage.apsx");
        }
     
        //Fetching book title to be added into cart from Session variable that is carried form the Catalog Page
        String book = (String)Session["booktocart"];

        lstCart.Items.Add(book);

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        btnCheckout.Visible = false;
        btnGoBack.Visible = true;
        if (lstCart.SelectedIndex < 0)
            lblMessage.Text = "Please select a book to remove from the above list";
        else
        {
            string num = Convert.ToString(lstCart.SelectedIndex + 1);
            string title = Convert.ToString(lstCart.SelectedValue);
            //catalogkey = "sBook" + num;
            string book = (String)Session["booktocart"];
            //book._InCart = false;
            Session["booktocart"] = book;
            lstCart.Items.Clear(); //Removing the deleted item from the cart


        }
    }
    protected void btnCheckout_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckOut.aspx");
    }
    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Catalog.aspx");
    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Logout.aspx");
    }
}