using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;


namespace BankService
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1 service = new Service1();
            if (RadioButton1.Checked)  //will check if the card is master card
            {
                bool func1 = false;
                func1 = service.bank("Master_card", (TextBox1.Text));
                if (func1)
                {
                    Label1.Text = "Card is valid";   
                }
                else
                {
                    Label1.Text = "Card is invalid";
                }

            }

            else if (RadioButton2.Checked)  //will check if the card is credit card
            {
                bool func = false;
                func = service.bank("Visa_card", (TextBox1.Text));
                if (func)
                {
                    Label1.Text = "Card is valid";
                }
                else
                {
                    Label1.Text = "Card is invalid";
                }

            }
            else   //will check if all fields are entered.
            {
                Label1.Text = "Enter all fields";
            }
        }
    }
}
