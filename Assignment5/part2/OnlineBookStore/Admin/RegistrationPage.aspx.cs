using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

public partial class RegistrationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If user not admin then redirect to Login Page
        if (Request.Cookies["AdminUser"].Value == null || Request.Cookies["AdminUser"].Value.Length == 0)
        {
            Response.Redirect("~/LoginPage.apsx");
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
    public string Encryption(string plain_text)
    {
        string encrypt_key = "ABHWIK268HHJK78GB3"; //Encryption key
        byte[] plaintextInBytes = Encoding.Unicode.GetBytes(plain_text);

        Aes Obj = Aes.Create(); // creation of encryption protocol object
        Rfc2898DeriveBytes Obj1 = new Rfc2898DeriveBytes(encrypt_key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }); //conversion of keys from byte to hexadecimal

        Obj.Key = Obj1.GetBytes(32); //creation of 32 byte key from the object
        Obj.IV = Obj1.GetBytes(16);

        MemoryStream memory_stream = new MemoryStream(); //creation of memory stream object
        CryptoStream crypto_stream = new CryptoStream(memory_stream, Obj.CreateEncryptor(), CryptoStreamMode.Write); //creation of cryptostream object

        crypto_stream.Write(plaintextInBytes, 0, plaintextInBytes.Length); //writing plain text to cryptosteam object
        crypto_stream.Close();
        plain_text = Convert.ToBase64String(memory_stream.ToArray()); //conversion of plain text to cipher text
        return plain_text; //return encrypted text
    }
    protected void submit(object sender, EventArgs e)
    {
        {

            String user = TextBox1.Text;
            String password = TextBox4.Text;
            String firstName = TextBox2.Text;
            String lastName = TextBox3.Text;
            String role = null;
            Button2.Visible = false;
            bool flag=false;
            if(RadioButton1.Checked)
            {
                role = "Manager";
            }
            else
            {
                role = "Staff";
            }
            if (TextBox4.Text != TextBox5.Text)
            {
                Label1.Text = "Password and Confirm Password doesnot match";
               // Label1.Text = "User Already Exist!!  Try a different User name";
                Button2.Visible = true;
                return;
            }
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
            {
                Label1.Text = "All fields are Mandatory!!";
                Button2.Visible = true;
                return;
                // Response.Redirect("RegistrationPage.aspx");
            }
           

            String filePath = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data", "UserInfo.xml");
           // String filePath = Application["GlobalData"].ToString();
            string returnString = "";
            if (!File.Exists(filePath))
            {
                returnString = "Database Error!!";
            }
            else
            {
                try
                {
                    XmlDocument xd = new XmlDocument();
                    xd.Load(filePath);
                    XPathDocument document = new XPathDocument(filePath);
                    XPathNavigator navigator = document.CreateNavigator();
                    navigator.MoveToChild("UserInformation", "");
                    XmlElement userName = xd.SelectSingleNode(String.Format("//information[@username='{0}']",user)) as XmlElement;
                 if (userName != null)
                    {
                        
                       //returnString = "Username already exists. Please choose a different Username";
                        Label1.Text = "User Already Exist!!  Try a different User name";
                        Button2.Visible = true;
                        return;
                       // Label1.Visible = true;
                    }
                    else
                    {
                        XmlElement dataElement = xd.SelectSingleNode(String.Format("//UserInformation", "")) as XmlElement;
                        XmlElement userElement = xd.CreateElement("information");
                        userElement.SetAttribute("username", "", user);
                        dataElement.AppendChild(userElement);
                        xd.Save(filePath);

                       //adding the new registered user's data in database
                        xd = new XmlDocument();
                        xd.Load(filePath);
                        navigator.MoveToChild("UserInformation", "");
                        userName = xd.SelectSingleNode(String.Format("//information[@username='{0}']",user)) as XmlElement;
                        String Encrypted_Password = Encryption(password);
                        XmlElement passwordElement = xd.CreateElement("Password");
                        passwordElement.InnerText = Encrypted_Password;
                        userName.AppendChild(passwordElement);
                        XmlElement first_name = xd.CreateElement("First");
                        first_name.InnerText = firstName;
                        userName.AppendChild(first_name);
                        XmlElement last_name = xd.CreateElement("Last");
                        last_name.InnerText = lastName;
                        userName.AppendChild(last_name);
                        XmlElement role_of_user = xd.CreateElement("Role");
                        role_of_user.InnerText = role;
                        userName.AppendChild(role_of_user);
                        xd.Save(filePath);
                        flag = true;
                    }

                }
                catch (Exception exception)
                {
                    returnString = "Database Error";
                }
                if(flag)
                {
                    Label2.Text = "User Registered Successfully !!";
                }

            }
        }

    }
    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged1(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged1(object sender, EventArgs e)
    {

    }
    protected void TextBox4_TextChanged1(object sender, EventArgs e)
    {

    }
    protected void TextBox5_TextChanged1(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistrationPage.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
  
        Response.Redirect("/Logout.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminHomePage.aspx");
    }
}