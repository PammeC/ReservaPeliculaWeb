﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitioReservaPeliculas.ServiceReference_Cliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_Cliente.ClienteSoap")]
    public interface ClienteSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento condicion del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mostrarCliente", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteResponse mostrarCliente(SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mostrarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteResponse> mostrarClienteAsync(SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registrarCliente", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteResponse registrarCliente(SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registrarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteResponse> registrarClienteAsync(SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento username del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validarUsuario", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioResponse validarUsuario(SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioResponse> validarUsuarioAsync(SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento eliminarClienteResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarCliente", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteResponse eliminarCliente(SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteResponse> eliminarClienteAsync(SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modificarCliente", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteResponse modificarCliente(SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modificarCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteResponse> modificarClienteAsync(SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class mostrarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="mostrarCliente", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequestBody Body;
        
        public mostrarClienteRequest() {
        }
        
        public mostrarClienteRequest(SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class mostrarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string condicion;
        
        public mostrarClienteRequestBody() {
        }
        
        public mostrarClienteRequestBody(string condicion) {
            this.condicion = condicion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class mostrarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="mostrarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteResponseBody Body;
        
        public mostrarClienteResponse() {
        }
        
        public mostrarClienteResponse(SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class mostrarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string mostrarClienteResult;
        
        public mostrarClienteResponseBody() {
        }
        
        public mostrarClienteResponseBody(string mostrarClienteResult) {
            this.mostrarClienteResult = mostrarClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registrarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarCliente", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequestBody Body;
        
        public registrarClienteRequest() {
        }
        
        public registrarClienteRequest(SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class registrarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string contraseña;
        
        public registrarClienteRequestBody() {
        }
        
        public registrarClienteRequestBody(string nombre, string apellido, string email, string contraseña) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.contraseña = contraseña;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registrarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteResponseBody Body;
        
        public registrarClienteResponse() {
        }
        
        public registrarClienteResponse(SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class registrarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string registrarClienteResult;
        
        public registrarClienteResponseBody() {
        }
        
        public registrarClienteResponseBody(string registrarClienteResult) {
            this.registrarClienteResult = registrarClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequestBody Body;
        
        public validarUsuarioRequest() {
        }
        
        public validarUsuarioRequest(SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class validarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public validarUsuarioRequestBody() {
        }
        
        public validarUsuarioRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioResponseBody Body;
        
        public validarUsuarioResponse() {
        }
        
        public validarUsuarioResponse(SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class validarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string validarUsuarioResult;
        
        public validarUsuarioResponseBody() {
        }
        
        public validarUsuarioResponseBody(string validarUsuarioResult) {
            this.validarUsuarioResult = validarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarCliente", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequestBody Body;
        
        public eliminarClienteRequest() {
        }
        
        public eliminarClienteRequest(SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int íd;
        
        public eliminarClienteRequestBody() {
        }
        
        public eliminarClienteRequestBody(int íd) {
            this.íd = íd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteResponseBody Body;
        
        public eliminarClienteResponse() {
        }
        
        public eliminarClienteResponse(SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string eliminarClienteResult;
        
        public eliminarClienteResponseBody() {
        }
        
        public eliminarClienteResponseBody(string eliminarClienteResult) {
            this.eliminarClienteResult = eliminarClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class modificarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="modificarCliente", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequestBody Body;
        
        public modificarClienteRequest() {
        }
        
        public modificarClienteRequest(SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class modificarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string contraseña;
        
        public modificarClienteRequestBody() {
        }
        
        public modificarClienteRequestBody(int id, string nombre, string apellido, string email, string contraseña) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.contraseña = contraseña;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class modificarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="modificarClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteResponseBody Body;
        
        public modificarClienteResponse() {
        }
        
        public modificarClienteResponse(SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class modificarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string modificarClienteResult;
        
        public modificarClienteResponseBody() {
        }
        
        public modificarClienteResponseBody(string modificarClienteResult) {
            this.modificarClienteResult = modificarClienteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClienteSoapChannel : SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteSoapClient : System.ServiceModel.ClientBase<SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap>, SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap {
        
        public ClienteSoapClient() {
        }
        
        public ClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteResponse SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.mostrarCliente(SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequest request) {
            return base.Channel.mostrarCliente(request);
        }
        
        public string mostrarCliente(string condicion) {
            SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequestBody();
            inValue.Body.condicion = condicion;
            SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteResponse retVal = ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).mostrarCliente(inValue);
            return retVal.Body.mostrarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteResponse> SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.mostrarClienteAsync(SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequest request) {
            return base.Channel.mostrarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteResponse> mostrarClienteAsync(string condicion) {
            SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.mostrarClienteRequestBody();
            inValue.Body.condicion = condicion;
            return ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).mostrarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteResponse SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.registrarCliente(SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequest request) {
            return base.Channel.registrarCliente(request);
        }
        
        public string registrarCliente(string nombre, string apellido, string email, string contraseña) {
            SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.email = email;
            inValue.Body.contraseña = contraseña;
            SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteResponse retVal = ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).registrarCliente(inValue);
            return retVal.Body.registrarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteResponse> SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.registrarClienteAsync(SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequest request) {
            return base.Channel.registrarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteResponse> registrarClienteAsync(string nombre, string apellido, string email, string contraseña) {
            SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.registrarClienteRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.email = email;
            inValue.Body.contraseña = contraseña;
            return ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).registrarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioResponse SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.validarUsuario(SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequest request) {
            return base.Channel.validarUsuario(request);
        }
        
        public string validarUsuario(string username, string password) {
            SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioResponse retVal = ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).validarUsuario(inValue);
            return retVal.Body.validarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioResponse> SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.validarUsuarioAsync(SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequest request) {
            return base.Channel.validarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioResponse> validarUsuarioAsync(string username, string password) {
            SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.validarUsuarioRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).validarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteResponse SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.eliminarCliente(SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequest request) {
            return base.Channel.eliminarCliente(request);
        }
        
        public string eliminarCliente(int íd) {
            SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequestBody();
            inValue.Body.íd = íd;
            SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteResponse retVal = ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).eliminarCliente(inValue);
            return retVal.Body.eliminarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteResponse> SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.eliminarClienteAsync(SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequest request) {
            return base.Channel.eliminarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteResponse> eliminarClienteAsync(int íd) {
            SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.eliminarClienteRequestBody();
            inValue.Body.íd = íd;
            return ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).eliminarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteResponse SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.modificarCliente(SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequest request) {
            return base.Channel.modificarCliente(request);
        }
        
        public string modificarCliente(int id, string nombre, string apellido, string email, string contraseña) {
            SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.email = email;
            inValue.Body.contraseña = contraseña;
            SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteResponse retVal = ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).modificarCliente(inValue);
            return retVal.Body.modificarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteResponse> SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap.modificarClienteAsync(SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequest request) {
            return base.Channel.modificarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteResponse> modificarClienteAsync(int id, string nombre, string apellido, string email, string contraseña) {
            SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequest inValue = new SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Cliente.modificarClienteRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.email = email;
            inValue.Body.contraseña = contraseña;
            return ((SitioReservaPeliculas.ServiceReference_Cliente.ClienteSoap)(this)).modificarClienteAsync(inValue);
        }
    }
}