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


namespace CrimeDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int[] CrimeData(string zip)
        {
            int [] crime = new int[5];
            
            string url = "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?includecrimedata=true&zipcode=" + zip;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);  
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());

            string data = reader.ReadToEnd(); //read complete contents of the webpage
            //parsing the xml document
            XmlReader read = XmlReader.Create(new StringReader(data));

            read.ReadToFollowing("ViolentCrime");
            crime[0] = Convert.ToInt32(read.ReadString());

            read.ReadToFollowing("PropertyCrime");
            crime[1] = Convert.ToInt32(read.ReadString());

            read.ReadToFollowing("LarcenyTheft");
            crime[2] = Convert.ToInt32(read.ReadString());

            read.ReadToFollowing("MotorVehicleTheft");
            crime[3] = Convert.ToInt32(read.ReadString());

            crime[4] = crime[0] + crime[1] + crime[2] + crime[3];

            return crime;

        }
    
    }
}
