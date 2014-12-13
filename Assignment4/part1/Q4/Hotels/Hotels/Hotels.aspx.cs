using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.Services;
using System.Net;
using System.Xml;
using System.IO;

/*
Reference: 
 http://msdn.microsoft.com/en-us/library/cc189056(VS.95).aspx 
 http://msdn.microsoft.com/en-us/library/system.xml.xmlreader.movetonextattribute(v=vs.110).aspx
 http://www.freeformatter.com/xsd-generator.html
 http://www.freeformatter.com/xsl-transformer.html
 */

namespace Hotels
{
    public partial class Hotels : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                
                string content = null;
                try
                {
                    XmlReader xml_read = XmlReader.Create((TextBox1.Text));
                    for (;xml_read.Read();)
                    {
                            if (XmlNodeType.Element == xml_read.NodeType)
                            {
                                content = content + "\n\n" + xml_read.Name;
                                if (xml_read.AttributeCount > 0)
                                {
                                    for (;xml_read.MoveToNextAttribute();)
                                        {
                                            if (xml_read.NodeType == XmlNodeType.Attribute)
                                                content = content + "  >>>>>>>  " + xml_read.Name + "  :  " + xml_read.Value;
                                        }
                                }
                            }
                            else if (XmlNodeType.Text == xml_read.NodeType)
                                content = content + "  >>>>>>>  " + "  :  " + xml_read.Value;
                        }
                        TextBox2.Text = content;
                   }
                catch (Exception ex)
                {
                    TextBox2.Text = " Wrong XML Link!!";
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

       
    