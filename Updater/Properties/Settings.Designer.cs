﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Updater.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string setFolder {
            get {
                return ((string)(this["setFolder"]));
            }
            set {
                this["setFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool setClosed {
            get {
                return ((bool)(this["setClosed"]));
            }
            set {
                this["setClosed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool setMinimized {
            get {
                return ((bool)(this["setMinimized"]));
            }
            set {
                this["setMinimized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public string firstInstall {
            get {
                return ((string)(this["firstInstall"]));
            }
            set {
                this["firstInstall"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int serverFileCount {
            get {
                return ((int)(this["serverFileCount"]));
            }
            set {
                this["serverFileCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string lastFileInList {
            get {
                return ((string)(this["lastFileInList"]));
            }
            set {
                this["lastFileInList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("anonymous")]
        public string ftpUser {
            get {
                return ((string)(this["ftpUser"]));
            }
            set {
                this["ftpUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/TarkinII/Updater/master/ftpUrl.txt")]
        public string ftpUpdateURL {
            get {
                return ((string)(this["ftpUpdateURL"]));
            }
            set {
                this["ftpUpdateURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://tarkinswg.com/tre/patch")]
        public string patchServerURL {
            get {
                return ((string)(this["patchServerURL"]));
            }
            set {
                this["patchServerURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://tarkinswg.com/index.php?/discover/all.xml/")]
        public string newsURL {
            get {
                return ((string)(this["newsURL"]));
            }
            set {
                this["newsURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/TarkinII/Updater/master/about.txt")]
        public string aboutURL {
            get {
                return ((string)(this["aboutURL"]));
            }
            set {
                this["aboutURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tarkinlogin.ddns.net")]
        public string statusURL {
            get {
                return ((string)(this["statusURL"]));
            }
            set {
                this["statusURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("44455")]
        public string statusPort {
            get {
                return ((string)(this["statusPort"]));
            }
            set {
                this["statusPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://tarkinswg.com/")]
        public string forumURL {
            get {
                return ((string)(this["forumURL"]));
            }
            set {
                this["forumURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("options.cfg swgemu.cfg user.cfg swgemu_machineoptions.iff SWGEmu.exe")]
        public string ignoreList {
            get {
                return ((string)(this["ignoreList"]));
            }
            set {
                this["ignoreList"] = value;
            }
        }
    }
}
