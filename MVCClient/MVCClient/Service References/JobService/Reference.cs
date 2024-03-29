﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCClient.JobService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JobModel", Namespace="http://schemas.datacontract.org/2004/07/Job_Openings")]
    [System.SerializableAttribute()]
    public partial class JobModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int JobIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobLocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobRoleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JobID {
            get {
                return this.JobIDField;
            }
            set {
                if ((this.JobIDField.Equals(value) != true)) {
                    this.JobIDField = value;
                    this.RaisePropertyChanged("JobID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobLocation {
            get {
                return this.JobLocationField;
            }
            set {
                if ((object.ReferenceEquals(this.JobLocationField, value) != true)) {
                    this.JobLocationField = value;
                    this.RaisePropertyChanged("JobLocation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobName {
            get {
                return this.JobNameField;
            }
            set {
                if ((object.ReferenceEquals(this.JobNameField, value) != true)) {
                    this.JobNameField = value;
                    this.RaisePropertyChanged("JobName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobRole {
            get {
                return this.JobRoleField;
            }
            set {
                if ((object.ReferenceEquals(this.JobRoleField, value) != true)) {
                    this.JobRoleField = value;
                    this.RaisePropertyChanged("JobRole");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobService.IJobService")]
    public interface IJobService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/GetListOfJobOpening", ReplyAction="http://tempuri.org/IJobService/GetListOfJobOpeningResponse")]
        System.Collections.Generic.List<MVCClient.JobService.JobModel> GetListOfJobOpening();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/GetListOfJobOpening", ReplyAction="http://tempuri.org/IJobService/GetListOfJobOpeningResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MVCClient.JobService.JobModel>> GetListOfJobOpeningAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/GetListOfJobOpeningByRole", ReplyAction="http://tempuri.org/IJobService/GetListOfJobOpeningByRoleResponse")]
        System.Collections.Generic.List<MVCClient.JobService.JobModel> GetListOfJobOpeningByRole(string JobRole);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/GetListOfJobOpeningByRole", ReplyAction="http://tempuri.org/IJobService/GetListOfJobOpeningByRoleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MVCClient.JobService.JobModel>> GetListOfJobOpeningByRoleAsync(string JobRole);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJobServiceChannel : MVCClient.JobService.IJobService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobServiceClient : System.ServiceModel.ClientBase<MVCClient.JobService.IJobService>, MVCClient.JobService.IJobService {
        
        public JobServiceClient() {
        }
        
        public JobServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<MVCClient.JobService.JobModel> GetListOfJobOpening() {
            return base.Channel.GetListOfJobOpening();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MVCClient.JobService.JobModel>> GetListOfJobOpeningAsync() {
            return base.Channel.GetListOfJobOpeningAsync();
        }
        
        public System.Collections.Generic.List<MVCClient.JobService.JobModel> GetListOfJobOpeningByRole(string JobRole) {
            return base.Channel.GetListOfJobOpeningByRole(JobRole);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MVCClient.JobService.JobModel>> GetListOfJobOpeningByRoleAsync(string JobRole) {
            return base.Channel.GetListOfJobOpeningByRoleAsync(JobRole);
        }
    }
}
