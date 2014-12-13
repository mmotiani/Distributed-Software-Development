using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Restful_WSDLdiscovery
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService5
    {

        [OperationContract]
        [WebGet(UriTemplate = "wsdl_discovery?key_word={key_word}")]

        string[] wsdl_discovery(string key_word);


    }
}
