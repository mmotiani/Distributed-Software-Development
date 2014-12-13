using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace verifyANDtransformSERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Itransformsvc" in both code and config file together.
    [ServiceContract]
    public interface Itransformsvc
    {

        [OperationContract]
        string transform(string xml1, string xsl1);
    }
}
