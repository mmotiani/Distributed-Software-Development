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
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml.Schema;

namespace Assignment4_Part2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ValidateXML" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ValidateXML.svc or ValidateXML.svc.cs at the Solution Explorer and start debugging.
    public class ValidateXML : IValidateXML
    {
        string answer;
        public string validate(string xml1, string xsd1)
        {
            try
            {
                XmlSchemaSet sc = new XmlSchemaSet();  // Create the XmlSchemaSet class
                sc.Add(null, xsd1);  // Add the schema to the collection before performing validation
                XmlReaderSettings settings = new XmlReaderSettings();   // Set the validation settings.
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas = sc;
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
                XmlReader read = XmlReader.Create(xml1, settings);    // Create the XmlReader object.
                // Parse the file.
                while (read.Read()) ; // will call event handler if invalid
                switch(answer)
                {
                    case null: return "Your XML document is Valid!! There is no ERROR in it!";
                    default: return "<html>" + answer + "</html>";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void ValidationCallBack(object sender, ValidationEventArgs eventarguments)
        {
            answer += eventarguments.Message;
        }
    }
}
