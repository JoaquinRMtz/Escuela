﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWS_validar_datos_Rocio.WebServiceDatos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://wsDatos/", ConfigurationName="WebServiceDatos.WSDDatosSOAP")]
    public interface WSDDatosSOAP {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento return del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://wsDatos/WSDDatosSOAP/consultaRequest", ReplyAction="http://wsDatos/WSDDatosSOAP/consultaResponse")]
        ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaResponse consulta(ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wsDatos/WSDDatosSOAP/consultaRequest", ReplyAction="http://wsDatos/WSDDatosSOAP/consultaResponse")]
        System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaResponse> consultaAsync(ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento json del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://wsDatos/WSDDatosSOAP/insertarRequest", ReplyAction="http://wsDatos/WSDDatosSOAP/insertarResponse")]
        ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarResponse insertar(ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wsDatos/WSDDatosSOAP/insertarRequest", ReplyAction="http://wsDatos/WSDDatosSOAP/insertarResponse")]
        System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarResponse> insertarAsync(ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento json del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://wsDatos/WSDDatosSOAP/actualizarRequest", ReplyAction="http://wsDatos/WSDDatosSOAP/actualizarResponse")]
        ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarResponse actualizar(ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wsDatos/WSDDatosSOAP/actualizarRequest", ReplyAction="http://wsDatos/WSDDatosSOAP/actualizarResponse")]
        System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarResponse> actualizarAsync(ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento json del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://wsDatos/WSDDatosSOAP/borrarRequest", ReplyAction="http://wsDatos/WSDDatosSOAP/borrarResponse")]
        ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarResponse borrar(ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wsDatos/WSDDatosSOAP/borrarRequest", ReplyAction="http://wsDatos/WSDDatosSOAP/borrarResponse")]
        System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarResponse> borrarAsync(ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class consultaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="consulta", Namespace="http://wsDatos/", Order=0)]
        public ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequestBody Body;
        
        public consultaRequest() {
        }
        
        public consultaRequest(ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class consultaRequestBody {
        
        public consultaRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class consultaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="consultaResponse", Namespace="http://wsDatos/", Order=0)]
        public ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaResponseBody Body;
        
        public consultaResponse() {
        }
        
        public consultaResponse(ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class consultaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public consultaResponseBody() {
        }
        
        public consultaResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertar", Namespace="http://wsDatos/", Order=0)]
        public ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequestBody Body;
        
        public insertarRequest() {
        }
        
        public insertarRequest(ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class insertarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string json;
        
        public insertarRequestBody() {
        }
        
        public insertarRequestBody(string json) {
            this.json = json;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertarResponse", Namespace="http://wsDatos/", Order=0)]
        public ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarResponseBody Body;
        
        public insertarResponse() {
        }
        
        public insertarResponse(ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class insertarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public insertarResponseBody() {
        }
        
        public insertarResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class actualizarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="actualizar", Namespace="http://wsDatos/", Order=0)]
        public ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequestBody Body;
        
        public actualizarRequest() {
        }
        
        public actualizarRequest(ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class actualizarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string json;
        
        public actualizarRequestBody() {
        }
        
        public actualizarRequestBody(string json) {
            this.json = json;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class actualizarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="actualizarResponse", Namespace="http://wsDatos/", Order=0)]
        public ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarResponseBody Body;
        
        public actualizarResponse() {
        }
        
        public actualizarResponse(ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class actualizarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public actualizarResponseBody() {
        }
        
        public actualizarResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class borrarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="borrar", Namespace="http://wsDatos/", Order=0)]
        public ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequestBody Body;
        
        public borrarRequest() {
        }
        
        public borrarRequest(ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class borrarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string json;
        
        public borrarRequestBody() {
        }
        
        public borrarRequestBody(string json) {
            this.json = json;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class borrarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="borrarResponse", Namespace="http://wsDatos/", Order=0)]
        public ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarResponseBody Body;
        
        public borrarResponse() {
        }
        
        public borrarResponse(ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class borrarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public borrarResponseBody() {
        }
        
        public borrarResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSDDatosSOAPChannel : ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSDDatosSOAPClient : System.ServiceModel.ClientBase<ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP>, ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP {
        
        public WSDDatosSOAPClient() {
        }
        
        public WSDDatosSOAPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSDDatosSOAPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSDDatosSOAPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSDDatosSOAPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaResponse ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP.consulta(ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequest request) {
            return base.Channel.consulta(request);
        }
        
        public string consulta() {
            ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequest inValue = new ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequest();
            inValue.Body = new ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequestBody();
            ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaResponse retVal = ((ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP)(this)).consulta(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaResponse> ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP.consultaAsync(ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequest request) {
            return base.Channel.consultaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaResponse> consultaAsync() {
            ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequest inValue = new ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequest();
            inValue.Body = new ClienteWS_validar_datos_Rocio.WebServiceDatos.consultaRequestBody();
            return ((ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP)(this)).consultaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarResponse ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP.insertar(ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequest request) {
            return base.Channel.insertar(request);
        }
        
        public string insertar(string json) {
            ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequest inValue = new ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequest();
            inValue.Body = new ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequestBody();
            inValue.Body.json = json;
            ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarResponse retVal = ((ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP)(this)).insertar(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarResponse> ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP.insertarAsync(ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequest request) {
            return base.Channel.insertarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarResponse> insertarAsync(string json) {
            ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequest inValue = new ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequest();
            inValue.Body = new ClienteWS_validar_datos_Rocio.WebServiceDatos.insertarRequestBody();
            inValue.Body.json = json;
            return ((ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP)(this)).insertarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarResponse ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP.actualizar(ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequest request) {
            return base.Channel.actualizar(request);
        }
        
        public string actualizar(string json) {
            ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequest inValue = new ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequest();
            inValue.Body = new ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequestBody();
            inValue.Body.json = json;
            ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarResponse retVal = ((ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP)(this)).actualizar(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarResponse> ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP.actualizarAsync(ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequest request) {
            return base.Channel.actualizarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarResponse> actualizarAsync(string json) {
            ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequest inValue = new ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequest();
            inValue.Body = new ClienteWS_validar_datos_Rocio.WebServiceDatos.actualizarRequestBody();
            inValue.Body.json = json;
            return ((ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP)(this)).actualizarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarResponse ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP.borrar(ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequest request) {
            return base.Channel.borrar(request);
        }
        
        public string borrar(string json) {
            ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequest inValue = new ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequest();
            inValue.Body = new ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequestBody();
            inValue.Body.json = json;
            ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarResponse retVal = ((ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP)(this)).borrar(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarResponse> ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP.borrarAsync(ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequest request) {
            return base.Channel.borrarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarResponse> borrarAsync(string json) {
            ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequest inValue = new ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequest();
            inValue.Body = new ClienteWS_validar_datos_Rocio.WebServiceDatos.borrarRequestBody();
            inValue.Body.json = json;
            return ((ClienteWS_validar_datos_Rocio.WebServiceDatos.WSDDatosSOAP)(this)).borrarAsync(inValue);
        }
    }
}
