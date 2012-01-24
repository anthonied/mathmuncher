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
namespace MathMuncherMain.ExerciseService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://mathmuncher.co.za/ws/schema/ex", ConfigurationName="ExerciseService.Exercise")]
    public interface Exercise {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult Beginexercise(MathMuncherMain.ExerciseService.exerciseRequest request, System.AsyncCallback callback, object asyncState);
        
        void Endexercise(System.IAsyncResult result);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mathmuncher.co.za/ws/schema/ex")]
    public partial class exerciseRequestType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private clusterQuestionConfigType clusterQuestionConfigField;
        
        private exerciseRequestTypeType typeField;
        
        private bool typeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public clusterQuestionConfigType clusterQuestionConfig {
            get {
                return this.clusterQuestionConfigField;
            }
            set {
                this.clusterQuestionConfigField = value;
                this.RaisePropertyChanged("clusterQuestionConfig");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public exerciseRequestTypeType type {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mathmuncher.co.za/ws/schema/ex")]
    public partial class clusterQuestionConfigType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int numberOfQuestionsField;
        
        private bool numberOfQuestionsFieldSpecified;
        
        private int numberOfNodesField;
        
        private bool numberOfNodesFieldSpecified;
        
        private string allowedModifiersField;
        
        private string allowedNodesField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public int numberOfQuestions {
            get {
                return this.numberOfQuestionsField;
            }
            set {
                this.numberOfQuestionsField = value;
                this.RaisePropertyChanged("numberOfQuestions");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfQuestionsSpecified {
            get {
                return this.numberOfQuestionsFieldSpecified;
            }
            set {
                this.numberOfQuestionsFieldSpecified = value;
                this.RaisePropertyChanged("numberOfQuestionsSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public int numberOfNodes {
            get {
                return this.numberOfNodesField;
            }
            set {
                this.numberOfNodesField = value;
                this.RaisePropertyChanged("numberOfNodes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfNodesSpecified {
            get {
                return this.numberOfNodesFieldSpecified;
            }
            set {
                this.numberOfNodesFieldSpecified = value;
                this.RaisePropertyChanged("numberOfNodesSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string allowedModifiers {
            get {
                return this.allowedModifiersField;
            }
            set {
                this.allowedModifiersField = value;
                this.RaisePropertyChanged("allowedModifiers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string allowedNodes {
            get {
                return this.allowedNodesField;
            }
            set {
                this.allowedNodesField = value;
                this.RaisePropertyChanged("allowedNodes");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mathmuncher.co.za/ws/schema/ex")]
    public enum exerciseRequestTypeType {
        
        /// <remarks/>
        MULTIPLICATION,
        
        /// <remarks/>
        DIVISION,
        
        /// <remarks/>
        ADDITION,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class exerciseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="exerciseRequest", Namespace="http://mathmuncher.co.za/ws/schema/ex", Order=0)]
        public MathMuncherMain.ExerciseService.exerciseRequestType exerciseRequest1;
        
        public exerciseRequest() {
        }
        
        public exerciseRequest(MathMuncherMain.ExerciseService.exerciseRequestType exerciseRequest1) {
            this.exerciseRequest1 = exerciseRequest1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExerciseChannel : MathMuncherMain.ExerciseService.Exercise, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExerciseClient : System.ServiceModel.ClientBase<MathMuncherMain.ExerciseService.Exercise>, MathMuncherMain.ExerciseService.Exercise {
        
        private BeginOperationDelegate onBeginexerciseDelegate;
        
        private EndOperationDelegate onEndexerciseDelegate;
         
        private System.Threading.SendOrPostCallback onexerciseCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ExerciseClient() {
        }
        
        public ExerciseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExerciseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExerciseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExerciseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> exerciseCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult MathMuncherMain.ExerciseService.Exercise.Beginexercise(MathMuncherMain.ExerciseService.exerciseRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginexercise(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult Beginexercise(MathMuncherMain.ExerciseService.exerciseRequestType exerciseRequest1, System.AsyncCallback callback, object asyncState) {
            MathMuncherMain.ExerciseService.exerciseRequest inValue = new MathMuncherMain.ExerciseService.exerciseRequest();
            inValue.exerciseRequest1 = exerciseRequest1;
            return ((MathMuncherMain.ExerciseService.Exercise)(this)).Beginexercise(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void MathMuncherMain.ExerciseService.Exercise.Endexercise(System.IAsyncResult result) {
            base.Channel.Endexercise(result);
        }
        
        private System.IAsyncResult OnBeginexercise(object[] inValues, System.AsyncCallback callback, object asyncState) {
            MathMuncherMain.ExerciseService.exerciseRequestType exerciseRequest1 = ((MathMuncherMain.ExerciseService.exerciseRequestType)(inValues[0]));
            return this.Beginexercise(exerciseRequest1, callback, asyncState);
        }
        
        private object[] OnEndexercise(System.IAsyncResult result) {
            ((MathMuncherMain.ExerciseService.Exercise)(this)).Endexercise(result);
            return null;
        }
        
        private void OnexerciseCompleted(object state) {
            if ((this.exerciseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.exerciseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void exerciseAsync(MathMuncherMain.ExerciseService.exerciseRequestType exerciseRequest1) {
            this.exerciseAsync(exerciseRequest1, null);
        }
        
        public void exerciseAsync(MathMuncherMain.ExerciseService.exerciseRequestType exerciseRequest1, object userState) {
            if ((this.onBeginexerciseDelegate == null)) {
                this.onBeginexerciseDelegate = new BeginOperationDelegate(this.OnBeginexercise);
            }
            if ((this.onEndexerciseDelegate == null)) {
                this.onEndexerciseDelegate = new EndOperationDelegate(this.OnEndexercise);
            }
            if ((this.onexerciseCompletedDelegate == null)) {
                this.onexerciseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnexerciseCompleted);
            }
            base.InvokeAsync(this.onBeginexerciseDelegate, new object[] {
                        exerciseRequest1}, this.onEndexerciseDelegate, this.onexerciseCompletedDelegate, userState);
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
        
        protected override MathMuncherMain.ExerciseService.Exercise CreateChannel() {
            return new ExerciseClientChannel(this);
        }
        
        private class ExerciseClientChannel : ChannelBase<MathMuncherMain.ExerciseService.Exercise>, MathMuncherMain.ExerciseService.Exercise {
            
            public ExerciseClientChannel(System.ServiceModel.ClientBase<MathMuncherMain.ExerciseService.Exercise> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult Beginexercise(MathMuncherMain.ExerciseService.exerciseRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("exercise", _args, callback, asyncState);
                return _result;
            }
            
            public void Endexercise(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("exercise", _args, result);
            }
        }
    }
}
