﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Espera.Core {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class CoreSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static CoreSettings defaultInstance = ((CoreSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CoreSettings())));
        
        public static CoreSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StreamYoutube {
            get {
                return ((bool)(this["StreamYoutube"]));
            }
            set {
                this["StreamYoutube"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LockVolume {
            get {
                return ((bool)(this["LockVolume"]));
            }
            set {
                this["LockVolume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LockTime {
            get {
                return ((bool)(this["LockTime"]));
            }
            set {
                this["LockTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LockPlaylistRemoval {
            get {
                return ((bool)(this["LockPlaylistRemoval"]));
            }
            set {
                this["LockPlaylistRemoval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:30")]
        public global::System.TimeSpan PlaylistTimeout {
            get {
                return ((global::System.TimeSpan)(this["PlaylistTimeout"]));
            }
            set {
                this["PlaylistTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnablePlaylistTimeout {
            get {
                return ((bool)(this["EnablePlaylistTimeout"]));
            }
            set {
                this["EnablePlaylistTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LockLibraryRemoval {
            get {
                return ((bool)(this["LockLibraryRemoval"]));
            }
            set {
                this["LockLibraryRemoval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LockPlayPause {
            get {
                return ((bool)(this["LockPlayPause"]));
            }
            set {
                this["LockPlayPause"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LockPlaylistSwitching {
            get {
                return ((bool)(this["LockPlaylistSwitching"]));
            }
            set {
                this["LockPlaylistSwitching"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public float Volume {
            get {
                return ((float)(this["Volume"]));
            }
            set {
                this["Volume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int YoutubeStreamingQuality {
            get {
                return ((int)(this["YoutubeStreamingQuality"]));
            }
            set {
                this["YoutubeStreamingQuality"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StreamHighestYoutubeQuality {
            get {
                return ((bool)(this["StreamHighestYoutubeQuality"]));
            }
            set {
                this["StreamHighestYoutubeQuality"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:30:00")]
        public global::System.TimeSpan SongSourceUpdateInterval {
            get {
                return ((global::System.TimeSpan)(this["SongSourceUpdateInterval"]));
            }
            set {
                this["SongSourceUpdateInterval"] = value;
            }
        }
    }
}
