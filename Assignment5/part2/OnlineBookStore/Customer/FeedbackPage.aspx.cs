using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Text.RegularExpressions;

public partial class Customer_FeedbackPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Member"] == null || Request.Cookies["Member"].Value.Length == 0)
        {
            Response.Redirect("\\LoginPage.apsx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder("");

        sb.Append(TextBox1.Text);
        sb.Append("\n");
        sb.Append(TextBox2.Text);
        sb.Append("\n");
        sb.Append(TextBox3.Text);
        sb.Append("\n");
        sb.Append(TextBox4.Text);

       // FeedbackService.Service1Client client = new FeedbackService.Service1Client();
        TextBox5.Text = StoreData(sb.ToString());
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/logout.aspx");
    }
    public string StoreData(String s)
        {
            string username;
            string emailAddress;
            string feedbackSubject;
            string feedbackMessage;

            string[] elements = Regex.Split(s, "\n");
            username = elements[0];
            if (validateEmail(elements[1]))
            {
                emailAddress = elements[1];
            }

            else
                return "enter valid email address \n ";

            feedbackSubject = elements[2];
            feedbackMessage = elements[3];

            string str = "Successfully submitted feeback on " + feedbackSubject + " by " + username;

            return str;
        }

        public bool validateEmail(string value)
        {
            string str = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex regexString = new Regex(str);

            if (regexString.IsMatch(value))
                return true;
            else
            {
                //throw new ArgumentException("Not a valid Email address");
                return false;
            }
        }
    }
