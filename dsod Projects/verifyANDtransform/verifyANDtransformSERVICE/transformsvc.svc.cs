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
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml.Schema;

namespace verifyANDtransformSERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "transformsvc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select transformsvc.svc or transformsvc.svc.cs at the Solution Explorer and start debugging.
    public class transformsvc : Itransformsvc
    {

        public string transform(string xml1, string xsl1)
        {

            try
            {

                //create XPathDocument from the given XML
                XPathDocument xpath = new XPathDocument(xml1);

                XslCompiledTransform xmlCompileTransform = new XslCompiledTransform();
                xmlCompileTransform.Load(xsl1);

                //Store HTML file to the App_Data of the server
                string htmlDocPath = Path.Combine(Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data"), "HTMLDoc.html");
                //save the transformed HTML
                xmlCompileTransform.Transform(xml1, htmlDocPath);
                //Return string to the client
                return (new WebClient().DownloadString(htmlDocPath));

            }
            catch (Exception ex)
            {

                return "<html><b>" + ex.Message + "<br>" + ex.InnerException.GetBaseException() + "</b></html>";
            }
        }
    }
}
