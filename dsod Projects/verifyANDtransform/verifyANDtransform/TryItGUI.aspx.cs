using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace verifyANDtransform
{
    public partial class TryItGUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.IverifyClient client = new ServiceReference2.IverifyClient();
            Label1.Text = Convert.ToString(client.validateXML(TextBox1.Text, TextBox2.Text));
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.ItransformsvcClient client1 = new ServiceReference1.ItransformsvcClient();
            Label2.Text = Convert.ToString(client1.transformXmltoHtml(TextBox1.Text, TextBox3.Text));
        }
    }
}