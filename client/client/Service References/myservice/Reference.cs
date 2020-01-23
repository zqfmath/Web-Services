﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.myservice {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://functional.com", ConfigurationName="myservice.Service1Soap")]
    public interface Service1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/Login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Login(string ID, string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/Register", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Register(string ID, string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/Name", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Name();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/GetName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/GetList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetList(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/GetTrack", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetTrack(string playlist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/AddScore", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int AddScore(string playlist, string nickname, int score);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/AddTrack", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int AddTrack(string title, string artist, string album, string genre, string playlist, string Public);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/Mymarks", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Mymarks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/AddList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int AddList(string playlist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/DeleteList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int DeleteList(string playlist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/DeleteTrack", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int DeleteTrack(string title, string artist, string playlist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/RankList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable RankList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/RankTrack", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable RankTrack();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/RankListTop3", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable RankListTop3();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/RankTrackTop3", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable RankTrackTop3();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://functional.com/Logoff", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void Logoff();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : WindowsFormsApplication1.myservice.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.myservice.Service1Soap>, WindowsFormsApplication1.myservice.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Login(string ID, string word) {
            return base.Channel.Login(ID, word);
        }
        
        public int Register(string ID, string word) {
            return base.Channel.Register(ID, word);
        }
        
        public string Name() {
            return base.Channel.Name();
        }
        
        public System.Data.DataTable GetName() {
            return base.Channel.GetName();
        }
        
        public System.Data.DataTable GetList(string ID) {
            return base.Channel.GetList(ID);
        }
        
        public System.Data.DataTable GetTrack(string playlist) {
            return base.Channel.GetTrack(playlist);
        }
        
        public int AddScore(string playlist, string nickname, int score) {
            return base.Channel.AddScore(playlist, nickname, score);
        }
        
        public int AddTrack(string title, string artist, string album, string genre, string playlist, string Public) {
            return base.Channel.AddTrack(title, artist, album, genre, playlist, Public);
        }
        
        public System.Data.DataTable Mymarks() {
            return base.Channel.Mymarks();
        }
        
        public int AddList(string playlist) {
            return base.Channel.AddList(playlist);
        }
        
        public int DeleteList(string playlist) {
            return base.Channel.DeleteList(playlist);
        }
        
        public int DeleteTrack(string title, string artist, string playlist) {
            return base.Channel.DeleteTrack(title, artist, playlist);
        }
        
        public System.Data.DataTable RankList() {
            return base.Channel.RankList();
        }
        
        public System.Data.DataTable RankTrack() {
            return base.Channel.RankTrack();
        }
        
        public System.Data.DataTable RankListTop3() {
            return base.Channel.RankListTop3();
        }
        
        public System.Data.DataTable RankTrackTop3() {
            return base.Channel.RankTrackTop3();
        }
        
        public void Logoff() {
            base.Channel.Logoff();
        }
    }
}
