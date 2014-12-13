using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EncryptionDecryption
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1 service = new Service1();
            TextBox2.Text = Convert.ToString(service.Encryption(TextBox1.Text));
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Service1 service = new Service1();
            TextBox3.Text = Convert.ToString(service.Decryption(TextBox2.Text));
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}