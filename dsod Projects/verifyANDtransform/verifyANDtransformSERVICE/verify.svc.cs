using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;

namespace verifyANDtransformSERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : Iverify
    {
       
        string result;

        public string validate(string xml1, string xsd1)
        {


            try
            {
                //add XSDPath schema to the schema set
                XmlSchemaSet sc = new XmlSchemaSet();
                sc.Add(null, xsd1);

                //setting validation settings
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas = sc;
                settings.ValidationEventHandler += new ValidationEventHandler(Handler);

                //XML reader to read xml at XMLPath with the specified validation settings
                XmlReader rd = XmlReader.Create(xml1, settings);

                //Parse the file to catch any errors
                while (rd.Read()) ;

                //return the results
                if (result == null)
                    return "XML is Valid!! No errors found!";
                else
                    return "<html>" + result + "</html>";
            }
            catch (Exception e)
            {
                return result + "\n\n" + e.Message;
            }
        }


        private void Handler(object sender, ValidationEventArgs eventarguments)
        {
            //check for the error type
            //print warnings and errors
            if (eventarguments.Severity == XmlSeverityType.Error || eventarguments.Severity == XmlSeverityType.Warning)

                //output has the error description and the line and position where the error occurred
                result += "<br><br>" + String.Format("Line: {0}, Position: {1} \"{2}\"",
                       eventarguments.Exception.LineNumber, eventarguments.Exception.LinePosition, eventarguments.Exception.Message);

        }
    }
}
