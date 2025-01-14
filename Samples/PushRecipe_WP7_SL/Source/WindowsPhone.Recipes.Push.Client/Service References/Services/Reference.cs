﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace WindowsPhone.Recipes.Push.Client.Services {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServerInfo", Namespace="http://schemas.datacontract.org/2004/07/WindowsPhone.Recipes.Push.Server.Models")]
    public partial class ServerInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int CounterField;
        
        private string PushPatternField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Counter {
            get {
                return this.CounterField;
            }
            set {
                if ((this.CounterField.Equals(value) != true)) {
                    this.CounterField = value;
                    this.RaisePropertyChanged("Counter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PushPattern {
            get {
                return this.PushPatternField;
            }
            set {
                if ((object.ReferenceEquals(this.PushPatternField, value) != true)) {
                    this.PushPatternField = value;
                    this.RaisePropertyChanged("PushPattern");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services.IPushService")]
    public interface IPushService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPushService/Register", ReplyAction="http://tempuri.org/IPushService/RegisterResponse")]
        System.IAsyncResult BeginRegister(string userName, System.Uri channelUri, System.AsyncCallback callback, object asyncState);
        
        void EndRegister(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPushService/GetServerInfo", ReplyAction="http://tempuri.org/IPushService/GetServerInfoResponse")]
        System.IAsyncResult BeginGetServerInfo(System.AsyncCallback callback, object asyncState);
        
        WindowsPhone.Recipes.Push.Client.Services.ServerInfo EndGetServerInfo(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPushService/UpdateTile", ReplyAction="http://tempuri.org/IPushService/UpdateTileResponse")]
        System.IAsyncResult BeginUpdateTile(System.Uri channelUri, string parameter, System.AsyncCallback callback, object asyncState);
        
        void EndUpdateTile(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPushServiceChannel : WindowsPhone.Recipes.Push.Client.Services.IPushService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetServerInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetServerInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public WindowsPhone.Recipes.Push.Client.Services.ServerInfo Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((WindowsPhone.Recipes.Push.Client.Services.ServerInfo)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PushServiceClient : System.ServiceModel.ClientBase<WindowsPhone.Recipes.Push.Client.Services.IPushService>, WindowsPhone.Recipes.Push.Client.Services.IPushService {
        
        private BeginOperationDelegate onBeginRegisterDelegate;
        
        private EndOperationDelegate onEndRegisterDelegate;
        
        private System.Threading.SendOrPostCallback onRegisterCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetServerInfoDelegate;
        
        private EndOperationDelegate onEndGetServerInfoDelegate;
        
        private System.Threading.SendOrPostCallback onGetServerInfoCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateTileDelegate;
        
        private EndOperationDelegate onEndUpdateTileDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateTileCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public PushServiceClient() {
        }
        
        public PushServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PushServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PushServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PushServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> RegisterCompleted;
        
        public event System.EventHandler<GetServerInfoCompletedEventArgs> GetServerInfoCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UpdateTileCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WindowsPhone.Recipes.Push.Client.Services.IPushService.BeginRegister(string userName, System.Uri channelUri, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRegister(userName, channelUri, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void WindowsPhone.Recipes.Push.Client.Services.IPushService.EndRegister(System.IAsyncResult result) {
            base.Channel.EndRegister(result);
        }
        
        private System.IAsyncResult OnBeginRegister(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string userName = ((string)(inValues[0]));
            System.Uri channelUri = ((System.Uri)(inValues[1]));
            return ((WindowsPhone.Recipes.Push.Client.Services.IPushService)(this)).BeginRegister(userName, channelUri, callback, asyncState);
        }
        
        private object[] OnEndRegister(System.IAsyncResult result) {
            ((WindowsPhone.Recipes.Push.Client.Services.IPushService)(this)).EndRegister(result);
            return null;
        }
        
        private void OnRegisterCompleted(object state) {
            if ((this.RegisterCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RegisterCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RegisterAsync(string userName, System.Uri channelUri) {
            this.RegisterAsync(userName, channelUri, null);
        }
        
        public void RegisterAsync(string userName, System.Uri channelUri, object userState) {
            if ((this.onBeginRegisterDelegate == null)) {
                this.onBeginRegisterDelegate = new BeginOperationDelegate(this.OnBeginRegister);
            }
            if ((this.onEndRegisterDelegate == null)) {
                this.onEndRegisterDelegate = new EndOperationDelegate(this.OnEndRegister);
            }
            if ((this.onRegisterCompletedDelegate == null)) {
                this.onRegisterCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRegisterCompleted);
            }
            base.InvokeAsync(this.onBeginRegisterDelegate, new object[] {
                        userName,
                        channelUri}, this.onEndRegisterDelegate, this.onRegisterCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WindowsPhone.Recipes.Push.Client.Services.IPushService.BeginGetServerInfo(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetServerInfo(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsPhone.Recipes.Push.Client.Services.ServerInfo WindowsPhone.Recipes.Push.Client.Services.IPushService.EndGetServerInfo(System.IAsyncResult result) {
            return base.Channel.EndGetServerInfo(result);
        }
        
        private System.IAsyncResult OnBeginGetServerInfo(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((WindowsPhone.Recipes.Push.Client.Services.IPushService)(this)).BeginGetServerInfo(callback, asyncState);
        }
        
        private object[] OnEndGetServerInfo(System.IAsyncResult result) {
            WindowsPhone.Recipes.Push.Client.Services.ServerInfo retVal = ((WindowsPhone.Recipes.Push.Client.Services.IPushService)(this)).EndGetServerInfo(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetServerInfoCompleted(object state) {
            if ((this.GetServerInfoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetServerInfoCompleted(this, new GetServerInfoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetServerInfoAsync() {
            this.GetServerInfoAsync(null);
        }
        
        public void GetServerInfoAsync(object userState) {
            if ((this.onBeginGetServerInfoDelegate == null)) {
                this.onBeginGetServerInfoDelegate = new BeginOperationDelegate(this.OnBeginGetServerInfo);
            }
            if ((this.onEndGetServerInfoDelegate == null)) {
                this.onEndGetServerInfoDelegate = new EndOperationDelegate(this.OnEndGetServerInfo);
            }
            if ((this.onGetServerInfoCompletedDelegate == null)) {
                this.onGetServerInfoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetServerInfoCompleted);
            }
            base.InvokeAsync(this.onBeginGetServerInfoDelegate, null, this.onEndGetServerInfoDelegate, this.onGetServerInfoCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WindowsPhone.Recipes.Push.Client.Services.IPushService.BeginUpdateTile(System.Uri channelUri, string parameter, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdateTile(channelUri, parameter, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void WindowsPhone.Recipes.Push.Client.Services.IPushService.EndUpdateTile(System.IAsyncResult result) {
            base.Channel.EndUpdateTile(result);
        }
        
        private System.IAsyncResult OnBeginUpdateTile(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.Uri channelUri = ((System.Uri)(inValues[0]));
            string parameter = ((string)(inValues[1]));
            return ((WindowsPhone.Recipes.Push.Client.Services.IPushService)(this)).BeginUpdateTile(channelUri, parameter, callback, asyncState);
        }
        
        private object[] OnEndUpdateTile(System.IAsyncResult result) {
            ((WindowsPhone.Recipes.Push.Client.Services.IPushService)(this)).EndUpdateTile(result);
            return null;
        }
        
        private void OnUpdateTileCompleted(object state) {
            if ((this.UpdateTileCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateTileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateTileAsync(System.Uri channelUri, string parameter) {
            this.UpdateTileAsync(channelUri, parameter, null);
        }
        
        public void UpdateTileAsync(System.Uri channelUri, string parameter, object userState) {
            if ((this.onBeginUpdateTileDelegate == null)) {
                this.onBeginUpdateTileDelegate = new BeginOperationDelegate(this.OnBeginUpdateTile);
            }
            if ((this.onEndUpdateTileDelegate == null)) {
                this.onEndUpdateTileDelegate = new EndOperationDelegate(this.OnEndUpdateTile);
            }
            if ((this.onUpdateTileCompletedDelegate == null)) {
                this.onUpdateTileCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateTileCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateTileDelegate, new object[] {
                        channelUri,
                        parameter}, this.onEndUpdateTileDelegate, this.onUpdateTileCompletedDelegate, userState);
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
        
        protected override WindowsPhone.Recipes.Push.Client.Services.IPushService CreateChannel() {
            return new PushServiceClientChannel(this);
        }
        
        private class PushServiceClientChannel : ChannelBase<WindowsPhone.Recipes.Push.Client.Services.IPushService>, WindowsPhone.Recipes.Push.Client.Services.IPushService {
            
            public PushServiceClientChannel(System.ServiceModel.ClientBase<WindowsPhone.Recipes.Push.Client.Services.IPushService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginRegister(string userName, System.Uri channelUri, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = userName;
                _args[1] = channelUri;
                System.IAsyncResult _result = base.BeginInvoke("Register", _args, callback, asyncState);
                return _result;
            }
            
            public void EndRegister(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("Register", _args, result);
            }
            
            public System.IAsyncResult BeginGetServerInfo(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetServerInfo", _args, callback, asyncState);
                return _result;
            }
            
            public WindowsPhone.Recipes.Push.Client.Services.ServerInfo EndGetServerInfo(System.IAsyncResult result) {
                object[] _args = new object[0];
                WindowsPhone.Recipes.Push.Client.Services.ServerInfo _result = ((WindowsPhone.Recipes.Push.Client.Services.ServerInfo)(base.EndInvoke("GetServerInfo", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginUpdateTile(System.Uri channelUri, string parameter, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = channelUri;
                _args[1] = parameter;
                System.IAsyncResult _result = base.BeginInvoke("UpdateTile", _args, callback, asyncState);
                return _result;
            }
            
            public void EndUpdateTile(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("UpdateTile", _args, result);
            }
        }
    }
}
