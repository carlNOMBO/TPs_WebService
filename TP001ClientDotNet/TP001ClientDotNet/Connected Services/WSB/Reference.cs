//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP001ClientDotNet.WSB {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws/", ConfigurationName="WSB.BanqueService")]
    public interface BanqueService {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/listCompteRequest", ReplyAction="http://ws/BanqueService/listCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        TP001ClientDotNet.WSB.listCompteResponse listCompte(TP001ClientDotNet.WSB.listCompteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/listCompteRequest", ReplyAction="http://ws/BanqueService/listCompteResponse")]
        System.Threading.Tasks.Task<TP001ClientDotNet.WSB.listCompteResponse> listCompteAsync(TP001ClientDotNet.WSB.listCompteRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/ConversionEuroToDHRequest", ReplyAction="http://ws/BanqueService/ConversionEuroToDHResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        TP001ClientDotNet.WSB.ConversionEuroToDHResponse ConversionEuroToDH(TP001ClientDotNet.WSB.ConversionEuroToDHRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/ConversionEuroToDHRequest", ReplyAction="http://ws/BanqueService/ConversionEuroToDHResponse")]
        System.Threading.Tasks.Task<TP001ClientDotNet.WSB.ConversionEuroToDHResponse> ConversionEuroToDHAsync(TP001ClientDotNet.WSB.ConversionEuroToDHRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/getCompteRequest", ReplyAction="http://ws/BanqueService/getCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        TP001ClientDotNet.WSB.getCompteResponse getCompte(TP001ClientDotNet.WSB.getCompteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/getCompteRequest", ReplyAction="http://ws/BanqueService/getCompteResponse")]
        System.Threading.Tasks.Task<TP001ClientDotNet.WSB.getCompteResponse> getCompteAsync(TP001ClientDotNet.WSB.getCompteRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws/")]
    public partial class compte : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long codeField;
        
        private double soldeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double solde {
            get {
                return this.soldeField;
            }
            set {
                this.soldeField = value;
                this.RaisePropertyChanged("solde");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listCompte", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listCompteRequest {
        
        public listCompteRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listCompteResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listCompteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TP001ClientDotNet.WSB.compte[] @return;
        
        public listCompteResponse() {
        }
        
        public listCompteResponse(TP001ClientDotNet.WSB.compte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDH", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ConversionEuroToDHRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double montant;
        
        public ConversionEuroToDHRequest() {
        }
        
        public ConversionEuroToDHRequest(double montant) {
            this.montant = montant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDHResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ConversionEuroToDHResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public ConversionEuroToDHResponse() {
        }
        
        public ConversionEuroToDHResponse(double @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompte", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getCompteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long code;
        
        public getCompteRequest() {
        }
        
        public getCompteRequest(long code) {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompteResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getCompteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TP001ClientDotNet.WSB.compte @return;
        
        public getCompteResponse() {
        }
        
        public getCompteResponse(TP001ClientDotNet.WSB.compte @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BanqueServiceChannel : TP001ClientDotNet.WSB.BanqueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BanqueServiceClient : System.ServiceModel.ClientBase<TP001ClientDotNet.WSB.BanqueService>, TP001ClientDotNet.WSB.BanqueService {
        
        public BanqueServiceClient() {
        }
        
        public BanqueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TP001ClientDotNet.WSB.listCompteResponse TP001ClientDotNet.WSB.BanqueService.listCompte(TP001ClientDotNet.WSB.listCompteRequest request) {
            return base.Channel.listCompte(request);
        }
        
        public TP001ClientDotNet.WSB.compte[] listCompte() {
            TP001ClientDotNet.WSB.listCompteRequest inValue = new TP001ClientDotNet.WSB.listCompteRequest();
            TP001ClientDotNet.WSB.listCompteResponse retVal = ((TP001ClientDotNet.WSB.BanqueService)(this)).listCompte(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TP001ClientDotNet.WSB.listCompteResponse> TP001ClientDotNet.WSB.BanqueService.listCompteAsync(TP001ClientDotNet.WSB.listCompteRequest request) {
            return base.Channel.listCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<TP001ClientDotNet.WSB.listCompteResponse> listCompteAsync() {
            TP001ClientDotNet.WSB.listCompteRequest inValue = new TP001ClientDotNet.WSB.listCompteRequest();
            return ((TP001ClientDotNet.WSB.BanqueService)(this)).listCompteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TP001ClientDotNet.WSB.ConversionEuroToDHResponse TP001ClientDotNet.WSB.BanqueService.ConversionEuroToDH(TP001ClientDotNet.WSB.ConversionEuroToDHRequest request) {
            return base.Channel.ConversionEuroToDH(request);
        }
        
        public double ConversionEuroToDH(double montant) {
            TP001ClientDotNet.WSB.ConversionEuroToDHRequest inValue = new TP001ClientDotNet.WSB.ConversionEuroToDHRequest();
            inValue.montant = montant;
            TP001ClientDotNet.WSB.ConversionEuroToDHResponse retVal = ((TP001ClientDotNet.WSB.BanqueService)(this)).ConversionEuroToDH(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TP001ClientDotNet.WSB.ConversionEuroToDHResponse> TP001ClientDotNet.WSB.BanqueService.ConversionEuroToDHAsync(TP001ClientDotNet.WSB.ConversionEuroToDHRequest request) {
            return base.Channel.ConversionEuroToDHAsync(request);
        }
        
        public System.Threading.Tasks.Task<TP001ClientDotNet.WSB.ConversionEuroToDHResponse> ConversionEuroToDHAsync(double montant) {
            TP001ClientDotNet.WSB.ConversionEuroToDHRequest inValue = new TP001ClientDotNet.WSB.ConversionEuroToDHRequest();
            inValue.montant = montant;
            return ((TP001ClientDotNet.WSB.BanqueService)(this)).ConversionEuroToDHAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TP001ClientDotNet.WSB.getCompteResponse TP001ClientDotNet.WSB.BanqueService.getCompte(TP001ClientDotNet.WSB.getCompteRequest request) {
            return base.Channel.getCompte(request);
        }
        
        public TP001ClientDotNet.WSB.compte getCompte(long code) {
            TP001ClientDotNet.WSB.getCompteRequest inValue = new TP001ClientDotNet.WSB.getCompteRequest();
            inValue.code = code;
            TP001ClientDotNet.WSB.getCompteResponse retVal = ((TP001ClientDotNet.WSB.BanqueService)(this)).getCompte(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TP001ClientDotNet.WSB.getCompteResponse> TP001ClientDotNet.WSB.BanqueService.getCompteAsync(TP001ClientDotNet.WSB.getCompteRequest request) {
            return base.Channel.getCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<TP001ClientDotNet.WSB.getCompteResponse> getCompteAsync(long code) {
            TP001ClientDotNet.WSB.getCompteRequest inValue = new TP001ClientDotNet.WSB.getCompteRequest();
            inValue.code = code;
            return ((TP001ClientDotNet.WSB.BanqueService)(this)).getCompteAsync(inValue);
        }
    }
}
