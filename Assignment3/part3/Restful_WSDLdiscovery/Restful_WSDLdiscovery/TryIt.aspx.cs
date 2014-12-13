using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

namespace Restful_WSDLdiscovery
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

            Response.Redirect("http://localhost:51786/Service1.svc/wsdl_discovery?key_word=" + TextBox1.Text);

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}