//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceRequest.Views {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class WindowsMapView : global::Xamarin.Forms.ContentView {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Grid Gl_Main;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::ServiceRequest.Custom.CustomMap _CustomMap;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::ServiceRequest.Custom.SRiButton BtnMap;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::ServiceRequest.Custom.SRiButton BtnSatellite;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(WindowsMapView));
            Gl_Main = this.FindByName<global::Xamarin.Forms.Grid>("Gl_Main");
            _CustomMap = this.FindByName<global::ServiceRequest.Custom.CustomMap>("_CustomMap");
            BtnMap = this.FindByName<global::ServiceRequest.Custom.SRiButton>("BtnMap");
            BtnSatellite = this.FindByName<global::ServiceRequest.Custom.SRiButton>("BtnSatellite");
        }
    }
}