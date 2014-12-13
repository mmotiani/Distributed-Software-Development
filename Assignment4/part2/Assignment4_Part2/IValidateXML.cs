using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment4_Part2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IValidateXML" in both code and config file together.
    [ServiceContract]
    public interface IValidateXML
    {
        [OperationContract]
        string validate(string xml1, string xsd1);
    }
}
