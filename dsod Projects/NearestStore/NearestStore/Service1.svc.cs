using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text;
using System.Web.Services;
using System.Net;
using System.Xml;
using System.IO;

namespace NearestStore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string NearestStore(string store, string zip)
        {
            decimal lon=0, lat=0;
           string url= "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?zipcode="+zip;
           // string url = "https://api.foursquare.com/v2/venues/search?intent="+store+"&intent="+zip ;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);  //Request for URL
            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //Response for the above request

            StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());

            string data = reader.ReadToEnd(); 
            XmlReader read = XmlReader.Create(new StringReader(data));
            read.ReadToFollowing("Longitude");
            lon = Convert.ToDecimal(read.ReadString());
            read.ReadToFollowing("Latitude");

            lat = Convert.ToDecimal(read.ReadString());
            string name = "";

            string url1 = "https://maps.googleapis.com/maps/api/place/nearbysearch/xml?name=" + store + "&location=" + lat + "," + lon + "&rankby=distance&key=WRITE KEY HERE";

            HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create(url1);  //Request for URL
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse(); //Response for the above request

            StreamReader reader1 = new System.IO.StreamReader(response1.GetResponseStream());

            string data1 = reader1.ReadToEnd();
            XmlReader read1 = XmlReader.Create(new StringReader(data1));
            read1.ReadToFollowing("vicinity");
            name = Convert.ToString(read1.ReadString());


          //  if ((read.NodeType == XmlNodeType.Element) && (read.NodeType != XmlNodeType.EndElement))
         //  {
            //    read.ReadToFollowing("annual"); //reading all the annual solar intensity
            //    name = Convert.ToString(read.ReadString());
        //  }
            return name; 

        }
    }
        
}
