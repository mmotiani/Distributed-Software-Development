using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncDec;

namespace DLLTryIt
{
    public partial class DllTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string str = TextBox1.Text;
            
            TextBox2.Text = Class1.Encryption(TextBox1.Text); // uses the Encryption funtion defined in the DLL file to encrypt the data
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Class1.Decryption(TextBox2.Text);  // uses the Decryption funtion defined in the DLL file to decrypt the data
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
    }
}