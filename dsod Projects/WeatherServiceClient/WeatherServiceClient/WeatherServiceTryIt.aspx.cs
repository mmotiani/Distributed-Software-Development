using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeatherServiceClient
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service4Client weath = new ServiceReference1.Service4Client();
            string[] data = weath.weather(TextBox1.Text);
            TextBox2.Text = data[0].ToString();
            TextBox3.Text = data[1].ToString();
            TextBox4.Text = data[2].ToString();
            TextBox5.Text = data[3].ToString();
            TextBox6.Text = data[4].ToString();




        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}