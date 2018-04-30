﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nehta.ELSv2010
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StandardErrorType", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
    public partial class StandardErrorType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Nehta.ELSv2010.StandardErrorCodeType errorCodeField;
        
        private string messageField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public Nehta.ELSv2010.StandardErrorCodeType errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StandardErrorCodeType", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
    public enum StandardErrorCodeType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        servicePermanentUnavailable = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        serviceTemporaryUnavailable = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        certificateSkiMissing = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        certificateKeyUsage = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        certificateUnidentified = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        invalidCredentials = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        notAuthenticated = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        notAuthorised = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badParam = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badlyFormedMsg = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badTimestamp = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badSignature = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badEncryption = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badSigEncOrder = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badCertificateTransmitted = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badWsaAction = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badWsaMessageId = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badWsaTo = 17,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmDataEncryption = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmKeyEncryption = 19,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmC14N = 20,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmDigest = 21,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmSignature = 22,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LookupErrorType", Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010")]
    public partial class LookupErrorType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Nehta.ELSv2010.LookupErrorCodeType errorCodeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public Nehta.ELSv2010.LookupErrorCodeType errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LookupErrorCodeType", Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010")]
    public enum LookupErrorCodeType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        unknownTargetId = 0,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PublishErrorType", Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010")]
    public partial class PublishErrorType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Nehta.ELSv2010.PublishErrorCodeType errorCodeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public Nehta.ELSv2010.PublishErrorCodeType errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PublishErrorCodeType", Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010")]
    public enum PublishErrorCodeType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        unknownTargetId = 0,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", ConfigurationName="Nehta.ELSv2010.Lookup")]
    public interface Lookup
    {
        
        // CODEGEN: Generating message contract since the operation listInteractions is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/listInteractionsRequ" +
            "est", ReplyAction="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/listInteractionsResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Nehta.ELSv2010.StandardErrorType), Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/listInteractions/Fau" +
            "lt/standardError", Name="standardError", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
        [System.ServiceModel.FaultContractAttribute(typeof(Nehta.ELSv2010.LookupErrorType), Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/listInteractions/Fau" +
            "lt/lookupError", Name="lookupError")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Nehta.ELSv2010.listInteractionsResponse listInteractions(Nehta.ELSv2010.listInteractionsRequest request);
        
        // CODEGEN: Generating message contract since the operation validateInteraction is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/validateInteractionR" +
            "equest", ReplyAction="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/validateInteractionR" +
            "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Nehta.ELSv2010.StandardErrorType), Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/validateInteraction/" +
            "Fault/standardError", Name="standardError", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
        [System.ServiceModel.FaultContractAttribute(typeof(Nehta.ELSv2010.LookupErrorType), Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/validateInteraction/" +
            "Fault/lookupError", Name="lookupError")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Nehta.ELSv2010.validateInteractionResponse1 validateInteraction(Nehta.ELSv2010.validateInteractionRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010")]
    public partial class listInteractions
    {
        
        private InteractionRequestType interactionRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public InteractionRequestType interactionRequest
        {
            get
            {
                return this.interactionRequestField;
            }
            set
            {
                this.interactionRequestField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/els/xsd/DataTypes/2010")]
    public partial class InteractionRequestType
    {
        
        private string targetField;
        
        private string[] serviceCategoryField;
        
        private string[] serviceInterfaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serviceCategory", DataType="anyURI", Order=1)]
        public string[] serviceCategory
        {
            get
            {
                return this.serviceCategoryField;
            }
            set
            {
                this.serviceCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serviceInterface", DataType="anyURI", Order=2)]
        public string[] serviceInterface
        {
            get
            {
                return this.serviceInterfaceField;
            }
            set
            {
                this.serviceInterfaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/qcr/xsd/QualifiedCertRef/2010")]
    public partial class QualifiedCertRefType
    {
        
        private string typeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/els/xsd/DataTypes/2010")]
    public partial class ElsCertRefType
    {
        
        private string useQualifierField;
        
        private QualifiedCertRefType qualifiedCertRefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string useQualifier
        {
            get
            {
                return this.useQualifierField;
            }
            set
            {
                this.useQualifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ns.electronichealth.net.au/qcr/xsd/QualifiedCertRef/2010", Order=1)]
        public QualifiedCertRefType qualifiedCertRef
        {
            get
            {
                return this.qualifiedCertRefField;
            }
            set
            {
                this.qualifiedCertRefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/els/xsd/DataTypes/2010")]
    public partial class InteractionType
    {
        
        private string targetField;
        
        private string serviceCategoryField;
        
        private string serviceInterfaceField;
        
        private string serviceEndpointField;
        
        private string serviceProviderField;
        
        private ElsCertRefType[] certRefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=1)]
        public string serviceCategory
        {
            get
            {
                return this.serviceCategoryField;
            }
            set
            {
                this.serviceCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=2)]
        public string serviceInterface
        {
            get
            {
                return this.serviceInterfaceField;
            }
            set
            {
                this.serviceInterfaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=3)]
        public string serviceEndpoint
        {
            get
            {
                return this.serviceEndpointField;
            }
            set
            {
                this.serviceEndpointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=4)]
        public string serviceProvider
        {
            get
            {
                return this.serviceProviderField;
            }
            set
            {
                this.serviceProviderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("certRef", Order=5)]
        public ElsCertRefType[] certRef
        {
            get
            {
                return this.certRefField;
            }
            set
            {
                this.certRefField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class listInteractionsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", Order=0)]
        public Nehta.ELSv2010.listInteractions listInteractions;
        
        public listInteractionsRequest()
        {
        }
        
        public listInteractionsRequest(Nehta.ELSv2010.listInteractions listInteractions)
        {
            this.listInteractions = listInteractions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class listInteractionsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listInteractionsResponse", Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("interaction", IsNullable=false)]
        public InteractionType[] listInteractionsResponse1;
        
        public listInteractionsResponse()
        {
        }
        
        public listInteractionsResponse(InteractionType[] listInteractionsResponse1)
        {
            this.listInteractionsResponse1 = listInteractionsResponse1;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010")]
    public partial class validateInteraction
    {
        
        private InteractionType interactionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public InteractionType interaction
        {
            get
            {
                return this.interactionField;
            }
            set
            {
                this.interactionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010")]
    public partial class validateInteractionResponse
    {
        
        private bool isValidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool isValid
        {
            get
            {
                return this.isValidField;
            }
            set
            {
                this.isValidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validateInteractionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", Order=0)]
        public Nehta.ELSv2010.validateInteraction validateInteraction;
        
        public validateInteractionRequest()
        {
        }
        
        public validateInteractionRequest(Nehta.ELSv2010.validateInteraction validateInteraction)
        {
            this.validateInteraction = validateInteraction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validateInteractionResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", Order=0)]
        public Nehta.ELSv2010.validateInteractionResponse validateInteractionResponse;
        
        public validateInteractionResponse1()
        {
        }
        
        public validateInteractionResponse1(Nehta.ELSv2010.validateInteractionResponse validateInteractionResponse)
        {
            this.validateInteractionResponse = validateInteractionResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface LookupChannel : Nehta.ELSv2010.Lookup, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class LookupClient : System.ServiceModel.ClientBase<Nehta.ELSv2010.Lookup>, Nehta.ELSv2010.Lookup
    {
        
        public LookupClient()
        {
        }
        
        public LookupClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public LookupClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public LookupClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public LookupClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nehta.ELSv2010.listInteractionsResponse Nehta.ELSv2010.Lookup.listInteractions(Nehta.ELSv2010.listInteractionsRequest request)
        {
            return base.Channel.listInteractions(request);
        }
        
        public InteractionType[] listInteractions(Nehta.ELSv2010.listInteractions listInteractions1)
        {
            Nehta.ELSv2010.listInteractionsRequest inValue = new Nehta.ELSv2010.listInteractionsRequest();
            inValue.listInteractions = listInteractions1;
            Nehta.ELSv2010.listInteractionsResponse retVal = ((Nehta.ELSv2010.Lookup)(this)).listInteractions(inValue);
            return retVal.listInteractionsResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nehta.ELSv2010.validateInteractionResponse1 Nehta.ELSv2010.Lookup.validateInteraction(Nehta.ELSv2010.validateInteractionRequest request)
        {
            return base.Channel.validateInteraction(request);
        }
        
        public Nehta.ELSv2010.validateInteractionResponse validateInteraction(Nehta.ELSv2010.validateInteraction validateInteraction1)
        {
            Nehta.ELSv2010.validateInteractionRequest inValue = new Nehta.ELSv2010.validateInteractionRequest();
            inValue.validateInteraction = validateInteraction1;
            Nehta.ELSv2010.validateInteractionResponse1 retVal = ((Nehta.ELSv2010.Lookup)(this)).validateInteraction(inValue);
            return retVal.validateInteractionResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010", ConfigurationName="Nehta.ELSv2010.Publish")]
    public interface Publish
    {
        
        // CODEGEN: Generating message contract since the operation addInteraction is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://ns.electronichealth.net.au/els/svc/Publish/2010/Publish/addInteractionRequ" +
            "est", ReplyAction="http://ns.electronichealth.net.au/els/svc/Publish/2010/Publish/addInteractionResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Nehta.ELSv2010.PublishErrorType), Action="http://ns.electronichealth.net.au/els/svc/Publish/2010/Publish/addInteraction/Fau" +
            "lt/publishError", Name="publishError")]
        [System.ServiceModel.FaultContractAttribute(typeof(Nehta.ELSv2010.StandardErrorType), Action="http://ns.electronichealth.net.au/els/svc/Publish/2010/Publish/addInteraction/Fau" +
            "lt/standardError", Name="standardError", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Nehta.ELSv2010.addInteractionResponse1 addInteraction(Nehta.ELSv2010.addInteractionRequest request);
        
        // CODEGEN: Generating message contract since the operation removeInteraction is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://ns.electronichealth.net.au/els/svc/Publish/2010/Publish/removeInteractionR" +
            "equest", ReplyAction="http://ns.electronichealth.net.au/els/svc/Publish/2010/Publish/removeInteractionR" +
            "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Nehta.ELSv2010.PublishErrorType), Action="http://ns.electronichealth.net.au/els/svc/Publish/2010/Publish/removeInteraction/" +
            "Fault/publishError", Name="publishError")]
        [System.ServiceModel.FaultContractAttribute(typeof(Nehta.ELSv2010.StandardErrorType), Action="http://ns.electronichealth.net.au/els/svc/Publish/2010/Publish/removeInteraction/" +
            "Fault/standardError", Name="standardError", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Nehta.ELSv2010.removeInteractionResponse1 removeInteraction(Nehta.ELSv2010.removeInteractionRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010")]
    public partial class addInteraction
    {
        
        private InteractionType interactionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public InteractionType interaction
        {
            get
            {
                return this.interactionField;
            }
            set
            {
                this.interactionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010")]
    public partial class addInteractionResponse
    {
        
        private PublishReturnCodeType returnCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PublishReturnCodeType returnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010")]
    public enum PublishReturnCodeType
    {
        
        /// <remarks/>
        ok,
        
        /// <remarks/>
        duplicate,
        
        /// <remarks/>
        notFound,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addInteractionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010", Order=0)]
        public Nehta.ELSv2010.addInteraction addInteraction;
        
        public addInteractionRequest()
        {
        }
        
        public addInteractionRequest(Nehta.ELSv2010.addInteraction addInteraction)
        {
            this.addInteraction = addInteraction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addInteractionResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010", Order=0)]
        public Nehta.ELSv2010.addInteractionResponse addInteractionResponse;
        
        public addInteractionResponse1()
        {
        }
        
        public addInteractionResponse1(Nehta.ELSv2010.addInteractionResponse addInteractionResponse)
        {
            this.addInteractionResponse = addInteractionResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010")]
    public partial class removeInteraction
    {
        
        private InteractionType interactionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public InteractionType interaction
        {
            get
            {
                return this.interactionField;
            }
            set
            {
                this.interactionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010")]
    public partial class removeInteractionResponse
    {
        
        private PublishReturnCodeType returnCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PublishReturnCodeType returnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class removeInteractionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010", Order=0)]
        public Nehta.ELSv2010.removeInteraction removeInteraction;
        
        public removeInteractionRequest()
        {
        }
        
        public removeInteractionRequest(Nehta.ELSv2010.removeInteraction removeInteraction)
        {
            this.removeInteraction = removeInteraction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class removeInteractionResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Publish/2010", Order=0)]
        public Nehta.ELSv2010.removeInteractionResponse removeInteractionResponse;
        
        public removeInteractionResponse1()
        {
        }
        
        public removeInteractionResponse1(Nehta.ELSv2010.removeInteractionResponse removeInteractionResponse)
        {
            this.removeInteractionResponse = removeInteractionResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface PublishChannel : Nehta.ELSv2010.Publish, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class PublishClient : System.ServiceModel.ClientBase<Nehta.ELSv2010.Publish>, Nehta.ELSv2010.Publish
    {
        
        public PublishClient()
        {
        }
        
        public PublishClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public PublishClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public PublishClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public PublishClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nehta.ELSv2010.addInteractionResponse1 Nehta.ELSv2010.Publish.addInteraction(Nehta.ELSv2010.addInteractionRequest request)
        {
            return base.Channel.addInteraction(request);
        }
        
        public Nehta.ELSv2010.addInteractionResponse addInteraction(Nehta.ELSv2010.addInteraction addInteraction1)
        {
            Nehta.ELSv2010.addInteractionRequest inValue = new Nehta.ELSv2010.addInteractionRequest();
            inValue.addInteraction = addInteraction1;
            Nehta.ELSv2010.addInteractionResponse1 retVal = ((Nehta.ELSv2010.Publish)(this)).addInteraction(inValue);
            return retVal.addInteractionResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nehta.ELSv2010.removeInteractionResponse1 Nehta.ELSv2010.Publish.removeInteraction(Nehta.ELSv2010.removeInteractionRequest request)
        {
            return base.Channel.removeInteraction(request);
        }
        
        public Nehta.ELSv2010.removeInteractionResponse removeInteraction(Nehta.ELSv2010.removeInteraction removeInteraction1)
        {
            Nehta.ELSv2010.removeInteractionRequest inValue = new Nehta.ELSv2010.removeInteractionRequest();
            inValue.removeInteraction = removeInteraction1;
            Nehta.ELSv2010.removeInteractionResponse1 retVal = ((Nehta.ELSv2010.Publish)(this)).removeInteraction(inValue);
            return retVal.removeInteractionResponse;
        }
    }
}