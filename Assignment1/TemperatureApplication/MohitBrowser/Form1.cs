using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MohitBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Web page creation
        private void button1_Click(object sender, EventArgs e)   //Search Button
        {
            webBrowser1.Navigate(textURL.Text);    //when clicked, open the required web page using the specified URL.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        // Encryption of the given string
        private void button2_Click(object sender, EventArgs e) // Encrypt Button
        {
            EncDecNamespace.ServiceClient client = new EncDecNamespace.ServiceClient(); //When clicked, encrypts the specied string.
            string str = client.Encrypt(textBox1.Text);
            textBox2.Text = str.ToString(); // displays the encrypted string
        }
        // Decryption of the given string
        private void button3_Click(object sender, EventArgs e) // DEcrypt Button
        {
            EncDecNamespace.ServiceClient client1 = new EncDecNamespace.ServiceClient(); //When clicked, decrypts the specified string
            string str1 = client1.Decrypt(textBox4.Text);
            textBox3.Text = str1.ToString();   // displays the decrypted string
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Stock Information
        private void button4_Click(object sender, EventArgs e)  //Get stock button
        {
            StockNamespace.ServiceClient client2 = new StockNamespace.ServiceClient(); // when clicked, gets the stock value of the specified company
            string n = client2.getStockquote(textBox5.Text);
            textBox6.Text = n.ToString();
        }
    }
}
