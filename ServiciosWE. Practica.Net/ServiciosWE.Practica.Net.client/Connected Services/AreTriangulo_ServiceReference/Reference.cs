//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap")]
    public interface Calcula_AreaWebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Dato1 del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cuadrado", ReplyAction="*")]
        ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoResponse Cuadrado(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cuadrado", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoResponse> CuadradoAsync(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Base del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Triangulo", ReplyAction="*")]
        ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloResponse Triangulo(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Triangulo", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloResponse> TrianguloAsync(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Radio del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Circulo", ReplyAction="*")]
        ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoResponse Circulo(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Circulo", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoResponse> CirculoAsync(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CuadradoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Cuadrado", Namespace="http://tempuri.org/", Order=0)]
        public ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequestBody Body;
        
        public CuadradoRequest() {
        }
        
        public CuadradoRequest(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CuadradoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Dato1;
        
        public CuadradoRequestBody() {
        }
        
        public CuadradoRequestBody(string Dato1) {
            this.Dato1 = Dato1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CuadradoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CuadradoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoResponseBody Body;
        
        public CuadradoResponse() {
        }
        
        public CuadradoResponse(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CuadradoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CuadradoResult;
        
        public CuadradoResponseBody() {
        }
        
        public CuadradoResponseBody(string CuadradoResult) {
            this.CuadradoResult = CuadradoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TrianguloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Triangulo", Namespace="http://tempuri.org/", Order=0)]
        public ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequestBody Body;
        
        public TrianguloRequest() {
        }
        
        public TrianguloRequest(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TrianguloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Base;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Altura;
        
        public TrianguloRequestBody() {
        }
        
        public TrianguloRequestBody(string Base, string Altura) {
            this.Base = Base;
            this.Altura = Altura;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TrianguloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TrianguloResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloResponseBody Body;
        
        public TrianguloResponse() {
        }
        
        public TrianguloResponse(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TrianguloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TrianguloResult;
        
        public TrianguloResponseBody() {
        }
        
        public TrianguloResponseBody(string TrianguloResult) {
            this.TrianguloResult = TrianguloResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CirculoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Circulo", Namespace="http://tempuri.org/", Order=0)]
        public ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequestBody Body;
        
        public CirculoRequest() {
        }
        
        public CirculoRequest(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CirculoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Radio;
        
        public CirculoRequestBody() {
        }
        
        public CirculoRequestBody(string Radio) {
            this.Radio = Radio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CirculoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CirculoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoResponseBody Body;
        
        public CirculoResponse() {
        }
        
        public CirculoResponse(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CirculoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CirculoResult;
        
        public CirculoResponseBody() {
        }
        
        public CirculoResponseBody(string CirculoResult) {
            this.CirculoResult = CirculoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Calcula_AreaWebServiceSoapChannel : ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Calcula_AreaWebServiceSoapClient : System.ServiceModel.ClientBase<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap>, ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap {
        
        public Calcula_AreaWebServiceSoapClient() {
        }
        
        public Calcula_AreaWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Calcula_AreaWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Calcula_AreaWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Calcula_AreaWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoResponse ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap.Cuadrado(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequest request) {
            return base.Channel.Cuadrado(request);
        }
        
        public string Cuadrado(string Dato1) {
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequest inValue = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequest();
            inValue.Body = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequestBody();
            inValue.Body.Dato1 = Dato1;
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoResponse retVal = ((ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap)(this)).Cuadrado(inValue);
            return retVal.Body.CuadradoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoResponse> ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap.CuadradoAsync(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequest request) {
            return base.Channel.CuadradoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoResponse> CuadradoAsync(string Dato1) {
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequest inValue = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequest();
            inValue.Body = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CuadradoRequestBody();
            inValue.Body.Dato1 = Dato1;
            return ((ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap)(this)).CuadradoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloResponse ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap.Triangulo(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequest request) {
            return base.Channel.Triangulo(request);
        }
        
        public string Triangulo(string Base, string Altura) {
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequest inValue = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequest();
            inValue.Body = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequestBody();
            inValue.Body.Base = Base;
            inValue.Body.Altura = Altura;
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloResponse retVal = ((ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap)(this)).Triangulo(inValue);
            return retVal.Body.TrianguloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloResponse> ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap.TrianguloAsync(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequest request) {
            return base.Channel.TrianguloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloResponse> TrianguloAsync(string Base, string Altura) {
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequest inValue = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequest();
            inValue.Body = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.TrianguloRequestBody();
            inValue.Body.Base = Base;
            inValue.Body.Altura = Altura;
            return ((ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap)(this)).TrianguloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoResponse ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap.Circulo(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequest request) {
            return base.Channel.Circulo(request);
        }
        
        public string Circulo(string Radio) {
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequest inValue = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequest();
            inValue.Body = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequestBody();
            inValue.Body.Radio = Radio;
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoResponse retVal = ((ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap)(this)).Circulo(inValue);
            return retVal.Body.CirculoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoResponse> ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap.CirculoAsync(ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequest request) {
            return base.Channel.CirculoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoResponse> CirculoAsync(string Radio) {
            ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequest inValue = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequest();
            inValue.Body = new ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.CirculoRequestBody();
            inValue.Body.Radio = Radio;
            return ((ServiciosWE.Practica.Net.client.AreTriangulo_ServiceReference.Calcula_AreaWebServiceSoap)(this)).CirculoAsync(inValue);
        }
    }
}
