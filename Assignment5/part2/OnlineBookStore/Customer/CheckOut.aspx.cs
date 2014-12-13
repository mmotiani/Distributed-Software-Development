using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Member"] == null || Request.Cookies["Member"].Value.Length == 0)
        {
            Response.Redirect("\\LoginPage.apsx");
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Calling the banking service for validating card details
        //BankingService.Service1Client client = new BankingService.Service1Client();
        if (RadioButton1.Checked)  //will check if the card is master card
        {
            bool func1 = false;
            func1 = bank("Master_card", (TextBox1.Text));
            if (func1)
            {
                Response.Redirect("FeedbackPage.aspx");
            }
            else
            {
                Label1.Text = "Card is invalid";
            }

        }

        else if (RadioButton2.Checked)  //will check if the card is credit card
        {
            bool func = false;
            func = bank("Visa_card", (TextBox1.Text));
            if (func)
            {
                Response.Redirect("homePage.aspx");
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckOut.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Logout.aspx");
    }
    public bool bank(string Card, string card_no)// bank method to validate the card
    {
        try
        {
            string str1 = "Master_card";   //string variable declaration
            string str2 = "Visa_card";

            byte[] digit = new byte[16]; //byte array to store the card no.
            if (card_no.Equals(null))
            {
                return false;
            }
            int length = 0;
            while (length < card_no.Length)
            {
                if (char.IsDigit(card_no, length)) //if statement to check if the entered no.s are digit or not
                {
                    digit[length] = byte.Parse(card_no[length].ToString());
                }
                else
                {
                    return false;
                }
                length++;
            }

            if (Card.Equals(str1)) //if statement to validate the Master Card
            {
                if (length != 16)
                    return false;
                if (digit[0] != 5 || digit[1] == 0 || digit[1] > 5)
                    return false;


            }
            if (Card.Equals(str2))   //if statement to validate the Visa Card
            {
                if (length != 16 && length != 13)
                    return false;
                if (digit[0] != 4)
                    return false;

            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }
}