﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace MathMuncherMain.Exercise {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://mathmuncher.co.za/ws/schemas/ex", ConfigurationName="Exercise.ExercisePort")]
    public interface ExercisePort {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginanthropodExercise(MathMuncherMain.Exercise.anthropodExerciseRequest1 request, System.AsyncCallback callback, object asyncState);
        
        MathMuncherMain.Exercise.anthropodExerciseResponse1 EndanthropodExercise(System.IAsyncResult result);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mathmuncher.co.za/ws/schemas/ex")]
    public partial class anthropodExerciseRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private exerciseType typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public exerciseType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
                this.RaisePropertyChanged("typeSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mathmuncher.co.za/ws/schemas/ex")]
    public enum exerciseType {
        
        /// <remarks/>
        MULTIPLICATION,
        
        /// <remarks/>
        DIVISION,
        
        /// <remarks/>
        ADDITION,
        
        /// <remarks/>
        MINUS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mathmuncher.co.za/ws/schemas/ex")]
    public partial class anthropodExerciseResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private anthropodExerciseResponseAnthropod[] anthropodField;
        
        private exerciseType typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("anthropod", Order=0)]
        public anthropodExerciseResponseAnthropod[] anthropod {
            get {
                return this.anthropodField;
            }
            set {
                this.anthropodField = value;
                this.RaisePropertyChanged("anthropod");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public exerciseType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
                this.RaisePropertyChanged("typeSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mathmuncher.co.za/ws/schemas/ex")]
    public partial class anthropodExerciseResponseAnthropod : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int bodyField;
        
        private string legsField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public int body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
                this.RaisePropertyChanged("body");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string legs {
            get {
                return this.legsField;
            }
            set {
                this.legsField = value;
                this.RaisePropertyChanged("legs");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class anthropodExerciseRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mathmuncher.co.za/ws/schemas/ex", Order=0)]
        public MathMuncherMain.Exercise.anthropodExerciseRequest anthropodExerciseRequest;
        
        public anthropodExerciseRequest1() {
        }
        
        public anthropodExerciseRequest1(MathMuncherMain.Exercise.anthropodExerciseRequest anthropodExerciseRequest) {
            this.anthropodExerciseRequest = anthropodExerciseRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class anthropodExerciseResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mathmuncher.co.za/ws/schemas/ex", Order=0)]
        public MathMuncherMain.Exercise.anthropodExerciseResponse anthropodExerciseResponse;
        
        public anthropodExerciseResponse1() {
        }
        
        public anthropodExerciseResponse1(MathMuncherMain.Exercise.anthropodExerciseResponse anthropodExerciseResponse) {
            this.anthropodExerciseResponse = anthropodExerciseResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExercisePortChannel : MathMuncherMain.Exercise.ExercisePort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class anthropodExerciseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public anthropodExerciseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MathMuncherMain.Exercise.anthropodExerciseResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MathMuncherMain.Exercise.anthropodExerciseResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExercisePortClient : System.ServiceModel.ClientBase<MathMuncherMain.Exercise.ExercisePort>, MathMuncherMain.Exercise.ExercisePort {
        
        private BeginOperationDelegate onBeginanthropodExerciseDelegate;
        
        private EndOperationDelegate onEndanthropodExerciseDelegate;
        
        private System.Threading.SendOrPostCallback onanthropodExerciseCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ExercisePortClient() {
        }
        
        public ExercisePortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExercisePortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExercisePortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExercisePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<anthropodExerciseCompletedEventArgs> anthropodExerciseCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult MathMuncherMain.Exercise.ExercisePort.BeginanthropodExercise(MathMuncherMain.Exercise.anthropodExerciseRequest1 request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginanthropodExercise(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginanthropodExercise(MathMuncherMain.Exercise.anthropodExerciseRequest anthropodExerciseRequest, System.AsyncCallback callback, object asyncState) {
            MathMuncherMain.Exercise.anthropodExerciseRequest1 inValue = new MathMuncherMain.Exercise.anthropodExerciseRequest1();
            inValue.anthropodExerciseRequest = anthropodExerciseRequest;
            return ((MathMuncherMain.Exercise.ExercisePort)(this)).BeginanthropodExercise(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MathMuncherMain.Exercise.anthropodExerciseResponse1 MathMuncherMain.Exercise.ExercisePort.EndanthropodExercise(System.IAsyncResult result) {
            return base.Channel.EndanthropodExercise(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private MathMuncherMain.Exercise.anthropodExerciseResponse EndanthropodExercise(System.IAsyncResult result) {
            MathMuncherMain.Exercise.anthropodExerciseResponse1 retVal = ((MathMuncherMain.Exercise.ExercisePort)(this)).EndanthropodExercise(result);
            return retVal.anthropodExerciseResponse;
        }
        
        private System.IAsyncResult OnBeginanthropodExercise(object[] inValues, System.AsyncCallback callback, object asyncState) {
            MathMuncherMain.Exercise.anthropodExerciseRequest anthropodExerciseRequest = ((MathMuncherMain.Exercise.anthropodExerciseRequest)(inValues[0]));
            return this.BeginanthropodExercise(anthropodExerciseRequest, callback, asyncState);
        }
        
        private object[] OnEndanthropodExercise(System.IAsyncResult result) {
            MathMuncherMain.Exercise.anthropodExerciseResponse retVal = this.EndanthropodExercise(result);
            return new object[] {
                    retVal};
        }
        
        private void OnanthropodExerciseCompleted(object state) {
            if ((this.anthropodExerciseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.anthropodExerciseCompleted(this, new anthropodExerciseCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void anthropodExerciseAsync(MathMuncherMain.Exercise.anthropodExerciseRequest anthropodExerciseRequest) {
            this.anthropodExerciseAsync(anthropodExerciseRequest, null);
        }
        
        public void anthropodExerciseAsync(MathMuncherMain.Exercise.anthropodExerciseRequest anthropodExerciseRequest, object userState) {
            if ((this.onBeginanthropodExerciseDelegate == null)) {
                this.onBeginanthropodExerciseDelegate = new BeginOperationDelegate(this.OnBeginanthropodExercise);
            }
            if ((this.onEndanthropodExerciseDelegate == null)) {
                this.onEndanthropodExerciseDelegate = new EndOperationDelegate(this.OnEndanthropodExercise);
            }
            if ((this.onanthropodExerciseCompletedDelegate == null)) {
                this.onanthropodExerciseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnanthropodExerciseCompleted);
            }
            base.InvokeAsync(this.onBeginanthropodExerciseDelegate, new object[] {
                        anthropodExerciseRequest}, this.onEndanthropodExerciseDelegate, this.onanthropodExerciseCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override MathMuncherMain.Exercise.ExercisePort CreateChannel() {
            return new ExercisePortClientChannel(this);
        }
        
        private class ExercisePortClientChannel : ChannelBase<MathMuncherMain.Exercise.ExercisePort>, MathMuncherMain.Exercise.ExercisePort {
            
            public ExercisePortClientChannel(System.ServiceModel.ClientBase<MathMuncherMain.Exercise.ExercisePort> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginanthropodExercise(MathMuncherMain.Exercise.anthropodExerciseRequest1 request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("anthropodExercise", _args, callback, asyncState);
                return _result;
            }
            
            public MathMuncherMain.Exercise.anthropodExerciseResponse1 EndanthropodExercise(System.IAsyncResult result) {
                object[] _args = new object[0];
                MathMuncherMain.Exercise.anthropodExerciseResponse1 _result = ((MathMuncherMain.Exercise.anthropodExerciseResponse1)(base.EndInvoke("anthropodExercise", _args, result)));
                return _result;
            }
        }
    }
}
