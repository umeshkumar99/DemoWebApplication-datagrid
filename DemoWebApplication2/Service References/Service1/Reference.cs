﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWebApplication2.Service1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://DemoWebSer/Calc", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfClsProductInfo", Namespace="http://DemoWebSer/Calc", ItemName="clsProductInfo")]
    [System.SerializableAttribute()]
    public class ArrayOfClsProductInfo : System.Collections.Generic.List<DemoWebApplication2.Service1.clsProductInfo> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsProductInfo", Namespace="http://DemoWebSer/Calc")]
    [System.SerializableAttribute()]
    public partial class clsProductInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShortDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullDescriptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ShortDescription {
            get {
                return this.ShortDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ShortDescriptionField, value) != true)) {
                    this.ShortDescriptionField = value;
                    this.RaisePropertyChanged("ShortDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string FullDescription {
            get {
                return this.FullDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.FullDescriptionField, value) != true)) {
                    this.FullDescriptionField = value;
                    this.RaisePropertyChanged("FullDescription");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://DemoWebSer/Calc", ConfigurationName="Service1.DemoWebServiceSoap")]
    public interface DemoWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://DemoWebSer/Calc is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://DemoWebSer/Calc/HelloWorld", ReplyAction="*")]
        DemoWebApplication2.Service1.HelloWorldResponse HelloWorld(DemoWebApplication2.Service1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DemoWebSer/Calc/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<DemoWebApplication2.Service1.HelloWorldResponse> HelloWorldAsync(DemoWebApplication2.Service1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since the wrapper name (MUL_x0020_2_x0020_NUM) of message MUL_x0020_2_x0020_NUM does not match the default value (mul2num)
        [System.ServiceModel.OperationContractAttribute(Action="http://DemoWebSer/Calc/MUL 2 NUM", ReplyAction="*")]
        DemoWebApplication2.Service1.MUL2NUM1 mul2num(DemoWebApplication2.Service1.MUL2NUM request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DemoWebSer/Calc/MUL 2 NUM", ReplyAction="*")]
        System.Threading.Tasks.Task<DemoWebApplication2.Service1.MUL2NUM1> mul2numAsync(DemoWebApplication2.Service1.MUL2NUM request);
        
        // CODEGEN: Generating message contract since element name GetcalculationResult from namespace http://DemoWebSer/Calc is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://DemoWebSer/Calc/Getcalculation", ReplyAction="*")]
        DemoWebApplication2.Service1.GetcalculationResponse Getcalculation(DemoWebApplication2.Service1.GetcalculationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DemoWebSer/Calc/Getcalculation", ReplyAction="*")]
        System.Threading.Tasks.Task<DemoWebApplication2.Service1.GetcalculationResponse> GetcalculationAsync(DemoWebApplication2.Service1.GetcalculationRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://DemoWebSer/Calc is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://DemoWebSer/Calc/GetProdData", ReplyAction="*")]
        DemoWebApplication2.Service1.GetProdDataResponse GetProdData(DemoWebApplication2.Service1.GetProdDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DemoWebSer/Calc/GetProdData", ReplyAction="*")]
        System.Threading.Tasks.Task<DemoWebApplication2.Service1.GetProdDataResponse> GetProdDataAsync(DemoWebApplication2.Service1.GetProdDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://DemoWebSer/Calc", Order=0)]
        public DemoWebApplication2.Service1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(DemoWebApplication2.Service1.HelloWorldRequestBody Body) {
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
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://DemoWebSer/Calc", Order=0)]
        public DemoWebApplication2.Service1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(DemoWebApplication2.Service1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://DemoWebSer/Calc")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MUL 2 NUM", WrapperNamespace="http://DemoWebSer/Calc", IsWrapped=true)]
    public partial class MUL2NUM {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DemoWebSer/Calc", Order=0)]
        public int num1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DemoWebSer/Calc", Order=1)]
        public int num2;
        
        public MUL2NUM() {
        }
        
        public MUL2NUM(int num1, int num2) {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MUL 2 NUMResponse", WrapperNamespace="http://DemoWebSer/Calc", IsWrapped=true)]
    public partial class MUL2NUM1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MUL_x0020_2_x0020_NUMResult", Namespace="http://DemoWebSer/Calc", Order=0)]
        public int MUL2NUMResult;
        
        public MUL2NUM1() {
        }
        
        public MUL2NUM1(int MUL2NUMResult) {
            this.MUL2NUMResult = MUL2NUMResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetcalculationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Getcalculation", Namespace="http://DemoWebSer/Calc", Order=0)]
        public DemoWebApplication2.Service1.GetcalculationRequestBody Body;
        
        public GetcalculationRequest() {
        }
        
        public GetcalculationRequest(DemoWebApplication2.Service1.GetcalculationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetcalculationRequestBody {
        
        public GetcalculationRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetcalculationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetcalculationResponse", Namespace="http://DemoWebSer/Calc", Order=0)]
        public DemoWebApplication2.Service1.GetcalculationResponseBody Body;
        
        public GetcalculationResponse() {
        }
        
        public GetcalculationResponse(DemoWebApplication2.Service1.GetcalculationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://DemoWebSer/Calc")]
    public partial class GetcalculationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DemoWebApplication2.Service1.ArrayOfString GetcalculationResult;
        
        public GetcalculationResponseBody() {
        }
        
        public GetcalculationResponseBody(DemoWebApplication2.Service1.ArrayOfString GetcalculationResult) {
            this.GetcalculationResult = GetcalculationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProdDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProdData", Namespace="http://DemoWebSer/Calc", Order=0)]
        public DemoWebApplication2.Service1.GetProdDataRequestBody Body;
        
        public GetProdDataRequest() {
        }
        
        public GetProdDataRequest(DemoWebApplication2.Service1.GetProdDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://DemoWebSer/Calc")]
    public partial class GetProdDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        public GetProdDataRequestBody() {
        }
        
        public GetProdDataRequestBody(string id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProdDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProdDataResponse", Namespace="http://DemoWebSer/Calc", Order=0)]
        public DemoWebApplication2.Service1.GetProdDataResponseBody Body;
        
        public GetProdDataResponse() {
        }
        
        public GetProdDataResponse(DemoWebApplication2.Service1.GetProdDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://DemoWebSer/Calc")]
    public partial class GetProdDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DemoWebApplication2.Service1.ArrayOfClsProductInfo GetProdDataResult;
        
        public GetProdDataResponseBody() {
        }
        
        public GetProdDataResponseBody(DemoWebApplication2.Service1.ArrayOfClsProductInfo GetProdDataResult) {
            this.GetProdDataResult = GetProdDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DemoWebServiceSoapChannel : DemoWebApplication2.Service1.DemoWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoWebServiceSoapClient : System.ServiceModel.ClientBase<DemoWebApplication2.Service1.DemoWebServiceSoap>, DemoWebApplication2.Service1.DemoWebServiceSoap {
        
        public DemoWebServiceSoapClient() {
        }
        
        public DemoWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DemoWebApplication2.Service1.HelloWorldResponse DemoWebApplication2.Service1.DemoWebServiceSoap.HelloWorld(DemoWebApplication2.Service1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            DemoWebApplication2.Service1.HelloWorldRequest inValue = new DemoWebApplication2.Service1.HelloWorldRequest();
            inValue.Body = new DemoWebApplication2.Service1.HelloWorldRequestBody();
            DemoWebApplication2.Service1.HelloWorldResponse retVal = ((DemoWebApplication2.Service1.DemoWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DemoWebApplication2.Service1.HelloWorldResponse> DemoWebApplication2.Service1.DemoWebServiceSoap.HelloWorldAsync(DemoWebApplication2.Service1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<DemoWebApplication2.Service1.HelloWorldResponse> HelloWorldAsync() {
            DemoWebApplication2.Service1.HelloWorldRequest inValue = new DemoWebApplication2.Service1.HelloWorldRequest();
            inValue.Body = new DemoWebApplication2.Service1.HelloWorldRequestBody();
            return ((DemoWebApplication2.Service1.DemoWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DemoWebApplication2.Service1.MUL2NUM1 DemoWebApplication2.Service1.DemoWebServiceSoap.mul2num(DemoWebApplication2.Service1.MUL2NUM request) {
            return base.Channel.mul2num(request);
        }
        
        public int mul2num(int num1, int num2) {
            DemoWebApplication2.Service1.MUL2NUM inValue = new DemoWebApplication2.Service1.MUL2NUM();
            inValue.num1 = num1;
            inValue.num2 = num2;
            DemoWebApplication2.Service1.MUL2NUM1 retVal = ((DemoWebApplication2.Service1.DemoWebServiceSoap)(this)).mul2num(inValue);
            return retVal.MUL2NUMResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DemoWebApplication2.Service1.MUL2NUM1> DemoWebApplication2.Service1.DemoWebServiceSoap.mul2numAsync(DemoWebApplication2.Service1.MUL2NUM request) {
            return base.Channel.mul2numAsync(request);
        }
        
        public System.Threading.Tasks.Task<DemoWebApplication2.Service1.MUL2NUM1> mul2numAsync(int num1, int num2) {
            DemoWebApplication2.Service1.MUL2NUM inValue = new DemoWebApplication2.Service1.MUL2NUM();
            inValue.num1 = num1;
            inValue.num2 = num2;
            return ((DemoWebApplication2.Service1.DemoWebServiceSoap)(this)).mul2numAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DemoWebApplication2.Service1.GetcalculationResponse DemoWebApplication2.Service1.DemoWebServiceSoap.Getcalculation(DemoWebApplication2.Service1.GetcalculationRequest request) {
            return base.Channel.Getcalculation(request);
        }
        
        public DemoWebApplication2.Service1.ArrayOfString Getcalculation() {
            DemoWebApplication2.Service1.GetcalculationRequest inValue = new DemoWebApplication2.Service1.GetcalculationRequest();
            inValue.Body = new DemoWebApplication2.Service1.GetcalculationRequestBody();
            DemoWebApplication2.Service1.GetcalculationResponse retVal = ((DemoWebApplication2.Service1.DemoWebServiceSoap)(this)).Getcalculation(inValue);
            return retVal.Body.GetcalculationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DemoWebApplication2.Service1.GetcalculationResponse> DemoWebApplication2.Service1.DemoWebServiceSoap.GetcalculationAsync(DemoWebApplication2.Service1.GetcalculationRequest request) {
            return base.Channel.GetcalculationAsync(request);
        }
        
        public System.Threading.Tasks.Task<DemoWebApplication2.Service1.GetcalculationResponse> GetcalculationAsync() {
            DemoWebApplication2.Service1.GetcalculationRequest inValue = new DemoWebApplication2.Service1.GetcalculationRequest();
            inValue.Body = new DemoWebApplication2.Service1.GetcalculationRequestBody();
            return ((DemoWebApplication2.Service1.DemoWebServiceSoap)(this)).GetcalculationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DemoWebApplication2.Service1.GetProdDataResponse DemoWebApplication2.Service1.DemoWebServiceSoap.GetProdData(DemoWebApplication2.Service1.GetProdDataRequest request) {
            return base.Channel.GetProdData(request);
        }
        
        public DemoWebApplication2.Service1.ArrayOfClsProductInfo GetProdData(string id) {
            DemoWebApplication2.Service1.GetProdDataRequest inValue = new DemoWebApplication2.Service1.GetProdDataRequest();
            inValue.Body = new DemoWebApplication2.Service1.GetProdDataRequestBody();
            inValue.Body.id = id;
            DemoWebApplication2.Service1.GetProdDataResponse retVal = ((DemoWebApplication2.Service1.DemoWebServiceSoap)(this)).GetProdData(inValue);
            return retVal.Body.GetProdDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DemoWebApplication2.Service1.GetProdDataResponse> DemoWebApplication2.Service1.DemoWebServiceSoap.GetProdDataAsync(DemoWebApplication2.Service1.GetProdDataRequest request) {
            return base.Channel.GetProdDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<DemoWebApplication2.Service1.GetProdDataResponse> GetProdDataAsync(string id) {
            DemoWebApplication2.Service1.GetProdDataRequest inValue = new DemoWebApplication2.Service1.GetProdDataRequest();
            inValue.Body = new DemoWebApplication2.Service1.GetProdDataRequestBody();
            inValue.Body.id = id;
            return ((DemoWebApplication2.Service1.DemoWebServiceSoap)(this)).GetProdDataAsync(inValue);
        }
    }
}
