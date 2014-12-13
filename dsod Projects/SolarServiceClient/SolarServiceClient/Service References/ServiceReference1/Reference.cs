﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolarServiceClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService3")]
    public interface IService3 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/SolarService", ReplyAction="http://tempuri.org/IService3/SolarServiceResponse")]
        decimal SolarService(decimal lat, decimal lon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/SolarService", ReplyAction="http://tempuri.org/IService3/SolarServiceResponse")]
        System.Threading.Tasks.Task<decimal> SolarServiceAsync(decimal lat, decimal lon);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService3Channel : SolarServiceClient.ServiceReference1.IService3, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service3Client : System.ServiceModel.ClientBase<SolarServiceClient.ServiceReference1.IService3>, SolarServiceClient.ServiceReference1.IService3 {
        
        public Service3Client() {
        }
        
        public Service3Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service3Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service3Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service3Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal SolarService(decimal lat, decimal lon) {
            return base.Channel.SolarService(lat, lon);
        }
        
        public System.Threading.Tasks.Task<decimal> SolarServiceAsync(decimal lat, decimal lon) {
            return base.Channel.SolarServiceAsync(lat, lon);
        }
    }
}