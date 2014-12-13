using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using EncDec;

public partial class NewUserRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //ImageVerifier.ServiceClient client = new ImageVerifier.ServiceClient();
        //string s = client.GetVerifierString("5");
        //Image1.ImageUrl=client.GetImage(s).ToString();
        //int n = 6;
        //string s;
        //XmlDocument woeidData = new XmlDocument();
        //woeidData.Load(String.Format("http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetVerifierString/{0}", n));
        //s = woeidData.GetElementsByTagName("string")[0].InnerText;
        //Image1.ImageUrl = String.Format("http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc//GetImage/{0}", s);
        
        
    }
    protected void submit(object sender, EventArgs e)
    {
        {

            String user = TextBox1.Text;
            String password = TextBox4.Text;
            String firstName = TextBox2.Text;
            String lastName = TextBox3.Text;
            String role = "Member";
            //String str = TextBox6.Text;
            Button2.Visible = false;
            
            if (TextBox4.Text != TextBox5.Text)
            {
                Label1.Text = "Password and Confirm Password doesnot match";
                Label1.Text = "User Already Exist!!  Try a different User name";
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
            //ImageVerifier.ServiceClient cl = new ImageVerifier.ServiceClient();
            ////cl.GetVerifierString("5");
            
            //ImageMap1.ImageUrl = cl.GetImage(cl.GetVerifierString("5")).ToString();

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
                    XmlElement userName = xd.SelectSingleNode(String.Format("//information[@username='{0}']", user)) as XmlElement;
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

                        //storing new user information in the database
                        xd = new XmlDocument();
                        xd.Load(filePath);
                        navigator.MoveToChild("UserInformation", "");
                        userName = xd.SelectSingleNode(String.Format("//information[@username='{0}']", user)) as XmlElement;
                        String Encrypted_Password = EncDec.Class1.Encryption(password);
                        XmlElement passwordElement = xd.CreateElement("Password");
                        passwordElement.InnerText = Encrypted_Password; // encrypting the password
                        userName.AppendChild(passwordElement); //Adding new user's encrypted password
                        XmlElement first_name = xd.CreateElement("First");
                        first_name.InnerText = firstName;
                        userName.AppendChild(first_name); //Adding new user's first name
                        XmlElement last_name = xd.CreateElement("Last");
                        last_name.InnerText = lastName;
                        userName.AppendChild(last_name); //Adding new user's last name
                        XmlElement role_of_user = xd.CreateElement("Role");
                        role_of_user.InnerText = role;
                        userName.AppendChild(role_of_user); //Adding new user's role
                        xd.Save(filePath);
                    }

                }
                catch (Exception exception)
                {
                    returnString = "Database Error";
                }

            }
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("homePage.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewUserRegistration.aspx");
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
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
}