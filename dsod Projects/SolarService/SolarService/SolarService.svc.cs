using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;
using System.Net;
using System.Xml;
using System.IO;

namespace SolarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService3
    {
        public decimal SolarService(decimal lati, decimal longi) //method to determine annual solar intensity
        {
            decimal avg_annual_solar_intensity=0;
            string url = "http://developer.nrel.gov/api/solar/solar_resource/v1.xml?api_key=DEMO_KEY&lat=" + lati + "&lon=" + longi;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);  //Request for URL
            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //Response for the above request

            StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());

            string data = reader.ReadToEnd(); //read complete contents of the webpage
            //parsing the xml document
            XmlReader read = XmlReader.Create(new StringReader(data));
            read.ReadToFollowing("avg-dni");
            if ((read.NodeType == XmlNodeType.Element) && (read.NodeType != XmlNodeType.EndElement))
           {
                read.ReadToFollowing("annual"); //reading all the annual solar intensity
                avg_annual_solar_intensity = Convert.ToDecimal(read.ReadString());
          }
            
            return avg_annual_solar_intensity; //return average annual solar intensity


        }
    }
}
