using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Google.API.Search;
using System.IO;

namespace Restful_WSDLdiscovery
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService5
    {
        public string[] wsdl_discovery(string key_word)
        {

            int x = 0;
            GwebSearchClient client = new GwebSearchClient(key_word);  //creation of object of google web search client
            var a = client.Search(key_word, 50); //search of all the wsdl services in the web page
            string[] str = new string[50];  //array to store all the wsdl services
            foreach (var array in a)
            {
                string extension = array.Url.ToString();
                if (Path.GetExtension(extension) == ".svc?WSDL")  //to check if there is any .svc?WSDL service
                {
                    str[x] = array.Url.ToString();
                    x++;
                }
                if (Path.GetExtension(extension) == ".svc?wsdl") //to check if there is any .svc?wsdl service
                {
                    str[x] = array.Url.ToString();
                    x++;
                }
                if (Path.GetExtension(extension) == ".asmx?wsdl")  //to check if there is any .asmx?wsdl service
                {
                  str[x] = array.Url.ToString();
                  x++;
                }
                if (Path.GetExtension(extension) == ".asmx?WSDL")   //to check if there is any .asmx?WSDL service
                {
                    str[x] = array.Url.ToString();
                    x++;
                }
                if (Path.GetExtension(extension) == ".php?wsdl")   //to check if there is any .php?wsdl service
                {
                    str[x] = array.Url.ToString();
                    x++;
                }
                if (Path.GetExtension(extension) == ".php?WSDL")    //to check if there is any .php?WSDL service
                {
                    str[x] = array.Url.ToString();
                    x++;
                }
                if(Path.GetExtension(extension) == ".wsdl")
                {
                    str[x] = array.Url.ToString();
                    x++;
                }
                
                
            }
            return str;
        }
    }
}
