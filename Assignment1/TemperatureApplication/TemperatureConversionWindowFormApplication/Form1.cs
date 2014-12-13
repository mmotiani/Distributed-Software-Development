using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversionWindowFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Conversion of celsius to farenheit
        private void button1_Click(object sender, EventArgs e)  //Convert to F button
        {
            TemperatureConversionWindowsNamespace.TemperatureConversionWebServiceSoapClient client = new TemperatureConversionWindowsNamespace.TemperatureConversionWebServiceSoapClient();
            int c = client.c2f(Convert.ToInt32(textBox1.Text));
            textBox2.Text = c.ToString();
        }
        //Conversion of farenheit to celsius
        private void button2_Click(object sender, EventArgs e) // Convert to C button
        {
            TemperatureConversionWindowsNamespace.TemperatureConversionWebServiceSoapClient client1 = new TemperatureConversionWindowsNamespace.TemperatureConversionWebServiceSoapClient();
            int f = client1.f2c(Convert.ToInt32(textBox4.Text));
            textBox3.Text = f.ToString();
        }
    }
}
