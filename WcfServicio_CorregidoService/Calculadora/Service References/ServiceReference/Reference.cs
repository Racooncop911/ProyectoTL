﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculadora.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSuma", ReplyAction="http://tempuri.org/IService1/GetSumaResponse")]
        float GetSuma(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSuma", ReplyAction="http://tempuri.org/IService1/GetSumaResponse")]
        System.Threading.Tasks.Task<float> GetSumaAsync(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetResta", ReplyAction="http://tempuri.org/IService1/GetRestaResponse")]
        float GetResta(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetResta", ReplyAction="http://tempuri.org/IService1/GetRestaResponse")]
        System.Threading.Tasks.Task<float> GetRestaAsync(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMulti", ReplyAction="http://tempuri.org/IService1/GetMultiResponse")]
        float GetMulti(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMulti", ReplyAction="http://tempuri.org/IService1/GetMultiResponse")]
        System.Threading.Tasks.Task<float> GetMultiAsync(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDiv", ReplyAction="http://tempuri.org/IService1/GetDivResponse")]
        float GetDiv(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDiv", ReplyAction="http://tempuri.org/IService1/GetDivResponse")]
        System.Threading.Tasks.Task<float> GetDivAsync(float a, float b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Calculadora.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Calculadora.ServiceReference.IService1>, Calculadora.ServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float GetSuma(float a, float b) {
            return base.Channel.GetSuma(a, b);
        }
        
        public System.Threading.Tasks.Task<float> GetSumaAsync(float a, float b) {
            return base.Channel.GetSumaAsync(a, b);
        }
        
        public float GetResta(float a, float b) {
            return base.Channel.GetResta(a, b);
        }
        
        public System.Threading.Tasks.Task<float> GetRestaAsync(float a, float b) {
            return base.Channel.GetRestaAsync(a, b);
        }
        
        public float GetMulti(float a, float b) {
            return base.Channel.GetMulti(a, b);
        }
        
        public System.Threading.Tasks.Task<float> GetMultiAsync(float a, float b) {
            return base.Channel.GetMultiAsync(a, b);
        }
        
        public float GetDiv(float a, float b) {
            return base.Channel.GetDiv(a, b);
        }
        
        public System.Threading.Tasks.Task<float> GetDivAsync(float a, float b) {
            return base.Channel.GetDivAsync(a, b);
        }
    }
}