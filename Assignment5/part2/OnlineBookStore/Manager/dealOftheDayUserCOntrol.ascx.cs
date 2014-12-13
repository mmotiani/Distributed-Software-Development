using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_dealOftheDayUserCOntrol : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // manager my_manager = new manager();
       // deal_of_the_day.Text = my_manager.dealoftheday();
        string[] arr = { "Software Engineering", "Service-Oriented Software Development", "Mobile Computing", "Database", "Data Mining", "Software Design", "BOOK7", "BOOK8", };
        Random r = new Random();
        string s = arr[r.Next(0, arr.Length)];
        deal_of_the_day.Text = "DEAL OF THE DAY is " + s + "...!!!!!!!!!!!";
    }
}