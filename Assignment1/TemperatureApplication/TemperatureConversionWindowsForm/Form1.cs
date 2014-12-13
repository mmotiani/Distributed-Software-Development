using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversionWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            TemperatureConversionWindowsNamespace.TemperatureConversionWebServiceSoapClient client = new TemperatureConversionWindowsNamespace.TemperatureConversionWebServiceSoapClient();
            int c = client.c2f(Convert.ToInt32(textBox1));
            textBox2.Text = c.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TemperatureConversionWindowsNamespace.TemperatureConversionWebServiceSoapClient client1 = new TemperatureConversionWindowsNamespace.TemperatureConversionWebServiceSoapClient();
            int f = client1.f2c(Convert.ToInt32(textBox3));
            textBox4.Text = f.ToString();
        }
    }
}
