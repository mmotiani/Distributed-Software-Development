using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI_TryIt_
{
    public partial class transformANDvalidateTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            transformservice.TransformXMLClient client = new transformservice.TransformXMLClient();
            Label1.Text = Convert.ToString(client.transform(TextBox1.Text, TextBox2.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            validateservice.ValidateXMLClient client1 = new validateservice.ValidateXMLClient();
            Label2.Text = Convert.ToString(client1.validate(TextBox1.Text, TextBox3.Text));
        }
    }
}