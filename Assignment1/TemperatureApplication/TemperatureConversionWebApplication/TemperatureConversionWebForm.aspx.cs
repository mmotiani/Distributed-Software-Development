using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemperatureConversionWebApplication
{
    public partial class TemperatureConversionWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Conversion of celsius to  farenheit
        protected void ButtonC2f_Click(object sender, EventArgs e)
        {
            TemperatureConversionNamespace.TemperatureConversionWebServiceSoapClient client = new TemperatureConversionNamespace.TemperatureConversionWebServiceSoapClient();
            int c = client.c2f(Convert.ToInt32(TextC.Text));
            LabelC2F.Text = c.ToString();
        }
        // Conversion of farenheit to celsius
        protected void ButtonF2C_Click(object sender, EventArgs e)
        {
            TemperatureConversionNamespace.TemperatureConversionWebServiceSoapClient client1 = new TemperatureConversionNamespace.TemperatureConversionWebServiceSoapClient();
            int f = client1.f2c(Convert.ToInt32(TextF.Text));
            LabelF2C.Text = f.ToString();
        }
    }
}