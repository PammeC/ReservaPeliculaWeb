﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitioReservaPeliculas.ServiceReference_Pelicula {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_Pelicula.PeliculaSoap")]
    public interface PeliculaSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento condicion del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mostrarPelicula", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaResponse mostrarPelicula(SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mostrarPelicula", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaResponse> mostrarPeliculaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registrarPelicula", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaResponse registrarPelicula(SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registrarPelicula", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaResponse> registrarPeliculaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento listarCategoriaResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listarCategoria", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaResponse listarCategoria(SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaResponse> listarCategoriaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento eliminarPeliculaResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarPelicula", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaResponse eliminarPelicula(SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarPelicula", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaResponse> eliminarPeliculaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modificarPelicula", ReplyAction="*")]
        SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaResponse modificarPelicula(SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modificarPelicula", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaResponse> modificarPeliculaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class mostrarPeliculaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="mostrarPelicula", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequestBody Body;
        
        public mostrarPeliculaRequest() {
        }
        
        public mostrarPeliculaRequest(SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class mostrarPeliculaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string condicion;
        
        public mostrarPeliculaRequestBody() {
        }
        
        public mostrarPeliculaRequestBody(string condicion) {
            this.condicion = condicion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class mostrarPeliculaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="mostrarPeliculaResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaResponseBody Body;
        
        public mostrarPeliculaResponse() {
        }
        
        public mostrarPeliculaResponse(SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class mostrarPeliculaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string mostrarPeliculaResult;
        
        public mostrarPeliculaResponseBody() {
        }
        
        public mostrarPeliculaResponseBody(string mostrarPeliculaResult) {
            this.mostrarPeliculaResult = mostrarPeliculaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registrarPeliculaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarPelicula", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequestBody Body;
        
        public registrarPeliculaRequest() {
        }
        
        public registrarPeliculaRequest(SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class registrarPeliculaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string descripcion;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int categoria;
        
        public registrarPeliculaRequestBody() {
        }
        
        public registrarPeliculaRequestBody(string nombre, string descripcion, int categoria) {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.categoria = categoria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registrarPeliculaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarPeliculaResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaResponseBody Body;
        
        public registrarPeliculaResponse() {
        }
        
        public registrarPeliculaResponse(SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class registrarPeliculaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string registrarPeliculaResult;
        
        public registrarPeliculaResponseBody() {
        }
        
        public registrarPeliculaResponseBody(string registrarPeliculaResult) {
            this.registrarPeliculaResult = registrarPeliculaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class listarCategoriaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listarCategoria", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequestBody Body;
        
        public listarCategoriaRequest() {
        }
        
        public listarCategoriaRequest(SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class listarCategoriaRequestBody {
        
        public listarCategoriaRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class listarCategoriaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listarCategoriaResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaResponseBody Body;
        
        public listarCategoriaResponse() {
        }
        
        public listarCategoriaResponse(SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class listarCategoriaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string listarCategoriaResult;
        
        public listarCategoriaResponseBody() {
        }
        
        public listarCategoriaResponseBody(string listarCategoriaResult) {
            this.listarCategoriaResult = listarCategoriaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarPeliculaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarPelicula", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequestBody Body;
        
        public eliminarPeliculaRequest() {
        }
        
        public eliminarPeliculaRequest(SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarPeliculaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int íd;
        
        public eliminarPeliculaRequestBody() {
        }
        
        public eliminarPeliculaRequestBody(int íd) {
            this.íd = íd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarPeliculaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarPeliculaResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaResponseBody Body;
        
        public eliminarPeliculaResponse() {
        }
        
        public eliminarPeliculaResponse(SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarPeliculaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string eliminarPeliculaResult;
        
        public eliminarPeliculaResponseBody() {
        }
        
        public eliminarPeliculaResponseBody(string eliminarPeliculaResult) {
            this.eliminarPeliculaResult = eliminarPeliculaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class modificarPeliculaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="modificarPelicula", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequestBody Body;
        
        public modificarPeliculaRequest() {
        }
        
        public modificarPeliculaRequest(SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class modificarPeliculaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string descripcion;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int categoria;
        
        public modificarPeliculaRequestBody() {
        }
        
        public modificarPeliculaRequestBody(int id, string nombre, string descripcion, int categoria) {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.categoria = categoria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class modificarPeliculaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="modificarPeliculaResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaResponseBody Body;
        
        public modificarPeliculaResponse() {
        }
        
        public modificarPeliculaResponse(SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class modificarPeliculaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string modificarPeliculaResult;
        
        public modificarPeliculaResponseBody() {
        }
        
        public modificarPeliculaResponseBody(string modificarPeliculaResult) {
            this.modificarPeliculaResult = modificarPeliculaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PeliculaSoapChannel : SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeliculaSoapClient : System.ServiceModel.ClientBase<SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap>, SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap {
        
        public PeliculaSoapClient() {
        }
        
        public PeliculaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeliculaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeliculaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeliculaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaResponse SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.mostrarPelicula(SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequest request) {
            return base.Channel.mostrarPelicula(request);
        }
        
        public string mostrarPelicula(string condicion) {
            SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequestBody();
            inValue.Body.condicion = condicion;
            SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaResponse retVal = ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).mostrarPelicula(inValue);
            return retVal.Body.mostrarPeliculaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaResponse> SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.mostrarPeliculaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequest request) {
            return base.Channel.mostrarPeliculaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaResponse> mostrarPeliculaAsync(string condicion) {
            SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.mostrarPeliculaRequestBody();
            inValue.Body.condicion = condicion;
            return ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).mostrarPeliculaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaResponse SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.registrarPelicula(SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequest request) {
            return base.Channel.registrarPelicula(request);
        }
        
        public string registrarPelicula(string nombre, string descripcion, int categoria) {
            SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.descripcion = descripcion;
            inValue.Body.categoria = categoria;
            SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaResponse retVal = ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).registrarPelicula(inValue);
            return retVal.Body.registrarPeliculaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaResponse> SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.registrarPeliculaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequest request) {
            return base.Channel.registrarPeliculaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaResponse> registrarPeliculaAsync(string nombre, string descripcion, int categoria) {
            SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.registrarPeliculaRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.descripcion = descripcion;
            inValue.Body.categoria = categoria;
            return ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).registrarPeliculaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaResponse SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.listarCategoria(SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequest request) {
            return base.Channel.listarCategoria(request);
        }
        
        public string listarCategoria() {
            SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequestBody();
            SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaResponse retVal = ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).listarCategoria(inValue);
            return retVal.Body.listarCategoriaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaResponse> SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.listarCategoriaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequest request) {
            return base.Channel.listarCategoriaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaResponse> listarCategoriaAsync() {
            SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.listarCategoriaRequestBody();
            return ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).listarCategoriaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaResponse SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.eliminarPelicula(SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequest request) {
            return base.Channel.eliminarPelicula(request);
        }
        
        public string eliminarPelicula(int íd) {
            SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequestBody();
            inValue.Body.íd = íd;
            SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaResponse retVal = ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).eliminarPelicula(inValue);
            return retVal.Body.eliminarPeliculaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaResponse> SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.eliminarPeliculaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequest request) {
            return base.Channel.eliminarPeliculaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaResponse> eliminarPeliculaAsync(int íd) {
            SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.eliminarPeliculaRequestBody();
            inValue.Body.íd = íd;
            return ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).eliminarPeliculaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaResponse SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.modificarPelicula(SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequest request) {
            return base.Channel.modificarPelicula(request);
        }
        
        public string modificarPelicula(int id, string nombre, string descripcion, int categoria) {
            SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.descripcion = descripcion;
            inValue.Body.categoria = categoria;
            SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaResponse retVal = ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).modificarPelicula(inValue);
            return retVal.Body.modificarPeliculaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaResponse> SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap.modificarPeliculaAsync(SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequest request) {
            return base.Channel.modificarPeliculaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaResponse> modificarPeliculaAsync(int id, string nombre, string descripcion, int categoria) {
            SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequest inValue = new SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequest();
            inValue.Body = new SitioReservaPeliculas.ServiceReference_Pelicula.modificarPeliculaRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.descripcion = descripcion;
            inValue.Body.categoria = categoria;
            return ((SitioReservaPeliculas.ServiceReference_Pelicula.PeliculaSoap)(this)).modificarPeliculaAsync(inValue);
        }
    }
}
