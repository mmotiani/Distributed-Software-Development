using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Security.Policy;
using System.IO;
using System.Xml.XmlConfiguration;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        String username = TextBox1.Text;
        String password = TextBox2.Text;
        String role = "";
        Session["user"] = username;
        XmlTextReader reader = null;
        bool userNameFound = false;
        
        if (TextBox1.Text == "" || TextBox2.Text == "")
        {
            Label1.Text = "All fields are Mandatory!!";
            Button2.Visible = true;
            return;
           
        }
       
        {
            try
            {
                String filePath = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data", "UserInfo.xml");
                
                reader = new XmlTextReader(filePath);

                XmlDocument xdcDocument = new XmlDocument();

                xdcDocument.Load(filePath);

                XmlElement xelRoot = xdcDocument.DocumentElement;
                XmlNodeList xnlNodes = xelRoot.SelectNodes("/UserInformation/information");

                foreach (XmlNode xndNode in xnlNodes)
                {
                    String uname = xndNode.Attributes["username"].Value;

                    if (uname == username)
                    {
                        userNameFound = true;

                        String pswd = xndNode["Password"].InnerText; //extracting encrypted password from database
                        String hashpswd = Encryption(password); //Encrypting the entered password
                        //comparing the entered password with the one stored in the database
                        if (!hashpswd.Equals(pswd)) 
                        {
                            Label1.Text = "Invalid UserName or Password";
                            Label1.Visible = true;
                            return;
                        }
                        role = xndNode["Role"].InnerText;
                        break;
                    }

                }

                //for (; reader.Read(); )
                //{
                //    if (reader.NodeType == XmlNodeType.Element)
                //    {
                //        if ("information".Equals(reader.Name))
                //        {
                //            if (username.Equals(reader.GetAttribute("username")))
                //            {
                //                userNameFound = true;
                //                for (; reader.Read(); )
                //                {
                //                    if (reader.NodeType == XmlNodeType.Element)
                //                    {
                //                        if ("Password".Equals(reader.Name))
                //                        {
                //                            String hashedPassword = EncDec.Class1.Encryption(password);
                //                            if (!hashedPassword.Equals(reader.ReadString()))
                //                            {
                //                                Label1.Text = "Invalid UserName or Password";
                //                                Label1.Visible = true;
                //                                return;
                //                            }
                //                        }
                //                        else if ("Role".Equals(reader.Name))
                //                        {
                //                            role = reader.ReadString();
                //                        }
                //                        else if ("information".Equals(reader.Name))
                //                        {
                //                            break;
                //                        }
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}

                if (!userNameFound)
                {
                    Label1.Text = "Invalid UserName or Password";
                    //Label1.Visible = true;
                    return;
                }

                //Redirecting users to pages based on thier  role
                if (role.Equals("Admin"))
                {
                    Response.Cookies["AdminUser"].Value = username;
                    Response.Redirect("Admin/AdminHomePage.aspx");
                }
                else if (role.Equals("Manager"))
                {
                    Response.Cookies["Manager"].Value = username;
                    Response.Redirect("Manager/manager.aspx");
                }
                else if (role.Equals("Staff"))
                {
                    Response.Cookies["Staff"].Value = username;
                    Response.Redirect("Staff/staff.aspx");
                }
                else if (role.Equals("Member"))
                {
                    Response.Cookies["Member"].Value = username;
                    Response.Redirect("Customer/Catalog.aspx");
                }

            }
            catch (Exception ex)
            {
                Label1.Text = "Some error has occured. Please try after sometime.";
                //Label3.Visible = true;
                return;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ImageVerifier.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}