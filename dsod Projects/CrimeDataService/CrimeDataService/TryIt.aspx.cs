using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrimeDataService
{
    public partial class TryIt : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1 crime = new Service1();
           int[] data = crime.CrimeData(TextBox1.Text);
            TextBox2.Text = data[0].ToString();
            TextBox3.Text = data[1].ToString();
            
            TextBox5.Text = data[2].ToString();
            TextBox6.Text = data[3].ToString();
           TextBox7.Text = data[4].ToString();
          //  TextBox8.Text = data[4].ToString();
           // TextBox9.Text = data[5].ToString();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

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

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}