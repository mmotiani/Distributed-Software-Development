﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace verifyANDtransform.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Itransformsvc")]
    public interface Itransformsvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Itransformsvc/transformXmltoHtml", ReplyAction="http://tempuri.org/Itransformsvc/transformXmltoHtmlResponse")]
        string transformXmltoHtml(string xmldocpath, string xsldocpath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Itransformsvc/transformXmltoHtml", ReplyAction="http://tempuri.org/Itransformsvc/transformXmltoHtmlResponse")]
        System.Threading.Tasks.Task<string> transformXmltoHtmlAsync(string xmldocpath, string xsldocpath);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ItransformsvcChannel : verifyANDtransform.ServiceReference1.Itransformsvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItransformsvcClient : System.ServiceModel.ClientBase<verifyANDtransform.ServiceReference1.Itransformsvc>, verifyANDtransform.ServiceReference1.Itransformsvc {
        
        public ItransformsvcClient() {
        }
        
        public ItransformsvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItransformsvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItransformsvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItransformsvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string transformXmltoHtml(string xmldocpath, string xsldocpath) {
            return base.Channel.transformXmltoHtml(xmldocpath, xsldocpath);
        }
        
        public System.Threading.Tasks.Task<string> transformXmltoHtmlAsync(string xmldocpath, string xsldocpath) {
            return base.Channel.transformXmltoHtmlAsync(xmldocpath, xsldocpath);
        }
    }
}
