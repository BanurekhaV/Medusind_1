//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wishes_WebApplication.WishesWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WishesWeb.WishesServiceSoap")]
    public interface WishesServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Wishes_WebApplication.WishesWeb.HelloWorldResponse HelloWorld(Wishes_WebApplication.WishesWeb.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Wishes_WebApplication.WishesWeb.HelloWorldResponse> HelloWorldAsync(Wishes_WebApplication.WishesWeb.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add2Nos", ReplyAction="*")]
        int Add2Nos(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add2Nos", ReplyAction="*")]
        System.Threading.Tasks.Task<int> Add2NosAsync(int x, int y);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Wishes_WebApplication.WishesWeb.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Wishes_WebApplication.WishesWeb.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Wishes_WebApplication.WishesWeb.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Wishes_WebApplication.WishesWeb.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WishesServiceSoapChannel : Wishes_WebApplication.WishesWeb.WishesServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WishesServiceSoapClient : System.ServiceModel.ClientBase<Wishes_WebApplication.WishesWeb.WishesServiceSoap>, Wishes_WebApplication.WishesWeb.WishesServiceSoap {
        
        public WishesServiceSoapClient() {
        }
        
        public WishesServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WishesServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WishesServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WishesServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Wishes_WebApplication.WishesWeb.HelloWorldResponse Wishes_WebApplication.WishesWeb.WishesServiceSoap.HelloWorld(Wishes_WebApplication.WishesWeb.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Wishes_WebApplication.WishesWeb.HelloWorldRequest inValue = new Wishes_WebApplication.WishesWeb.HelloWorldRequest();
            inValue.Body = new Wishes_WebApplication.WishesWeb.HelloWorldRequestBody();
            Wishes_WebApplication.WishesWeb.HelloWorldResponse retVal = ((Wishes_WebApplication.WishesWeb.WishesServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Wishes_WebApplication.WishesWeb.HelloWorldResponse> Wishes_WebApplication.WishesWeb.WishesServiceSoap.HelloWorldAsync(Wishes_WebApplication.WishesWeb.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Wishes_WebApplication.WishesWeb.HelloWorldResponse> HelloWorldAsync() {
            Wishes_WebApplication.WishesWeb.HelloWorldRequest inValue = new Wishes_WebApplication.WishesWeb.HelloWorldRequest();
            inValue.Body = new Wishes_WebApplication.WishesWeb.HelloWorldRequestBody();
            return ((Wishes_WebApplication.WishesWeb.WishesServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add2Nos(int x, int y) {
            return base.Channel.Add2Nos(x, y);
        }
        
        public System.Threading.Tasks.Task<int> Add2NosAsync(int x, int y) {
            return base.Channel.Add2NosAsync(x, y);
        }
    }
}
