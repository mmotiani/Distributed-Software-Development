using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TemperatureApplication
{
    /// <summary>
    /// Summary description for TemperatureConversionWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TemperatureConversionWebService : System.Web.Services.WebService
    {

        [WebMethod]

        public int c2f(int c)     // Method to convert Celsius to farenheit
        {
            return ((9 * c) / 5) + 32;
        }
        [WebMethod]
        public int f2c(int f)   // Method to convert farenheit to celsius
        {
            return ((f - 32) * 5) / 9;
        }
    }
}
