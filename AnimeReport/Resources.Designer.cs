﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.18449
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimeReport {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Resources : global::System.Configuration.ApplicationSettingsBase {
        
        private static Resources defaultInstance = ((Resources)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Resources())));
        
        public static Resources Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.1.0;Lista dei possibili stati di un record; 30/12/2014;Start at 1,Completed, St" +
            "all, Planning, Searching, In Direct, In Torrent, Waiting, To Move, To Transfer")]
        public string list_Status {
            get {
                return ((string)(this["list_Status"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("./imgs/")]
        public string img_folder {
            get {
                return ((string)(this["img_folder"]));
            }
        }
    }
}
