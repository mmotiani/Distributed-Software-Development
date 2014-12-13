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

namespace NewsFocus
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string newsfocus(string key)
        {
            string url = "http://news.yahoo.com/rss/entertainment";
            //string news = new string[10000];
            string news=null;
             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);  
            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); 
            StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());

            string data = reader.ReadToEnd(); 
            XmlReader read = XmlReader.Create(new StringReader(data));
            //int i=0;
            while(data!=null)
            {
                if(read.ReadToFollowing("title")||read.ReadToFollowing("description"))
                {
                   // read.ReadToFollowing("url");
                    //news[i]=Convert.ToString(read.ReadString());
                    read.ReadToFollowing("link");
                    news=news + Convert.ToString(read.ReadString());
                    news = news + "  ";
                    //i++;
                }

                return news;
    
            }
            
        }
        
           
            


        }

}
