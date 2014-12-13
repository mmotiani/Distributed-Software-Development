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

namespace WeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService4
    {
        public string[] weather(string zip)
        {                                               
            string[] ws ;   //string array variable
            ws = new string[5];                         
            string url1 = "http://api.openweathermap.org/data/2.5/forecast/daily?q="+zip+"&mode=xml&units=metric&cnt=5";  //url to get the weeather prediction for the 5 days.
            HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create(url1);  //Request for URL
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse(); //Response for the above request

            StreamReader reader1 = new System.IO.StreamReader(response1.GetResponseStream());

            string data1 = reader1.ReadToEnd(); //read complete contents of the webpage   
            //parsing the xml document
            XmlReader read1 = XmlReader.Create(new StringReader(data1));

            read1.ReadToFollowing("time");   //read the given tag in the xl document
            string day = read1.GetAttribute("day");  //read the given attribute in the specified tag
            ws[0] = "Day:: "+Convert.ToString(day)+"\n";

            read1.ReadToFollowing("temperature");   //read the given tag in the xl document
            string day1 = read1.GetAttribute("day");  //read the given attribute in the specified tag
            string min = read1.GetAttribute("min");  //read the given attribute in the specified tag
            string max = read1.GetAttribute("max");    //read the given attribute in the specified tag
            string night = read1.GetAttribute("night");    //read the given attribute in the specified tag
            string eve = read1.GetAttribute("eve");   //read the given attribute in the specified tag
            string morn = read1.GetAttribute("morn");   //read the given attribute in the specified tag

            ws[0] = ws[0] + "        Temperature::   Day:" + Convert.ToString(day1);  //adding extracted content from xml file to the first element of the array
            ws[0] = ws[0] + "   min:" + Convert.ToString(min);  
            ws[0] = ws[0] + "   max:" + Convert.ToString(max);
            ws[0] = ws[0] + "   night:" + Convert.ToString(night);
            ws[0] = ws[0] + "   eve:" + Convert.ToString(eve);
            ws[0] = ws[0] + "   morn:" + Convert.ToString(morn);

            read1.ReadToFollowing("time");
            string day2 = read1.GetAttribute("day");
            ws[1] = "Day:: " + Convert.ToString(day2) + "\n";

            read1.ReadToFollowing("temperature");
            string day3 = read1.GetAttribute("day");
            string min1 = read1.GetAttribute("min");
            string max1 = read1.GetAttribute("max");
            string night1 = read1.GetAttribute("night");
            string eve1 = read1.GetAttribute("eve");
            string morn1 = read1.GetAttribute("morn");

            ws[1] = ws[1] + "        Temperature::   Day:" + Convert.ToString(day3);
            ws[1] = ws[1] + "   min:" + Convert.ToString(min1);
            ws[1] = ws[1] + "   max:" + Convert.ToString(max1);
            ws[1] = ws[1] + "   night:" + Convert.ToString(night1);
            ws[1] = ws[1] + "   eve:" + Convert.ToString(eve1);
            ws[1] = ws[1] + "   morn:" + Convert.ToString(morn1);

            read1.ReadToFollowing("time");
            string day4 = read1.GetAttribute("day");
            ws[2] = "Day:: " + Convert.ToString(day4) + "\n";

            read1.ReadToFollowing("temperature");
            string day5 = read1.GetAttribute("day");
            string min3 = read1.GetAttribute("min");
            string max3 = read1.GetAttribute("max");
            string night3 = read1.GetAttribute("night");
            string eve3 = read1.GetAttribute("eve");
            string morn3 = read1.GetAttribute("morn");

            ws[2] = ws[2] + "        Temperature::   Day:" + Convert.ToString(day5);
            ws[2] = ws[2] + "   min:" + Convert.ToString(min3);
            ws[2] = ws[2] + "   max:" + Convert.ToString(max3);
            ws[2] = ws[2] + "   night:" + Convert.ToString(night3);
            ws[2] = ws[2] + "   eve:" + Convert.ToString(eve3);
            ws[2] = ws[2] + "   morn:" + Convert.ToString(morn3);

            read1.ReadToFollowing("time");
            string day6 = read1.GetAttribute("day");
            ws[3] = "Day:: " + Convert.ToString(day6) + "\n";

            read1.ReadToFollowing("temperature");
            string day7 = read1.GetAttribute("day");
            string min4 = read1.GetAttribute("min");
            string max4 = read1.GetAttribute("max");
            string night4 = read1.GetAttribute("night");
            string eve4 = read1.GetAttribute("eve");
            string morn4 = read1.GetAttribute("morn");

            ws[3] = ws[3] + "        Temperature::   Day:" + Convert.ToString(day7);
            ws[3] = ws[3] + "   min:" + Convert.ToString(min4);
            ws[3] = ws[3] + "   max:" + Convert.ToString(max4);
            ws[3] = ws[3] + "   night:" + Convert.ToString(night4);
            ws[3] = ws[3] + "   eve:" + Convert.ToString(eve4);
            ws[3] = ws[3] + "   morn:" + Convert.ToString(morn4);

            read1.ReadToFollowing("time");
            string day8 = read1.GetAttribute("day");
            ws[4] = "Day:: " + Convert.ToString(day8) + "\n";

            read1.ReadToFollowing("temperature");
            string day9 = read1.GetAttribute("day");
            string min5 = read1.GetAttribute("min");
            string max5 = read1.GetAttribute("max");
            string night5 = read1.GetAttribute("night");
            string eve5 = read1.GetAttribute("eve");
            string morn5 = read1.GetAttribute("morn");

            ws[4] = ws[4] + "        Temperature::   Day:" + Convert.ToString(day9);
            ws[4] = ws[4] + "   min:" + Convert.ToString(min5);
            ws[4] = ws[4] + "   max:" + Convert.ToString(max5);
            ws[4] = ws[4] + "   night:" + Convert.ToString(night5);
            ws[4] = ws[4] + "   eve:" + Convert.ToString(eve5);
            ws[4] = ws[4] + "   morn:" + Convert.ToString(morn5);

            return ws;  //return the array of string contatining 5 days weather prediction

        }
    
    }
}
