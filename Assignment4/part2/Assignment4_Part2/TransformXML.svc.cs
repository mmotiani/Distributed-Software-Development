using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Assignment4_Part2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TransformXML" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TransformXML.svc or TransformXML.svc.cs at the Solution Explorer and start debugging.
    public class TransformXML : ITransformXML
    {
        public string transform(string xml1, string xsl1)
        {
            try
            {
                XPathDocument path = new XPathDocument(xml1);  //XPathDocument object from the XML
                WebClient wb = new WebClient(); //creating object of web client
                string str = null;
                string html = null;
                string str1 = null;
                XslCompiledTransform xslt = new XslCompiledTransform();  //creating object of XslCompiledTransform
                xslt.Load(xsl1); //loading XSL document to XslCompiledTransform object
                str1 = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data");
                html = Path.Combine(str1, "Document.html"); //storing HTML to the server.
                xslt.Transform(xml1, html); //saving generated HTML document
                str = wb.DownloadString(html); 
                return (str); //returning html from the string
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
