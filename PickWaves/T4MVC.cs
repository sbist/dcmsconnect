﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC_PickWaves
{
    static readonly PickWavesClass s_PickWaves = new PickWavesClass();
    public static PickWavesClass PickWaves { get { return s_PickWaves; } }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class PickWavesClass
    {
        public readonly string Name = "PickWaves";
        public DcmsMobile.PickWaves.Areas.PickWaves.Controllers.AutoCompleteController AutoComplete = new DcmsMobile.PickWaves.Areas.PickWaves.Controllers.T4MVC_AutoCompleteController();
        public DcmsMobile.PickWaves.Areas.PickWaves.Controllers.BoxPickPalletController BoxPickPallet = new DcmsMobile.PickWaves.Areas.PickWaves.Controllers.T4MVC_BoxPickPalletController();
        public DcmsMobile.PickWaves.Areas.PickWaves.Controllers.ConfigController Config = new DcmsMobile.PickWaves.Areas.PickWaves.Controllers.T4MVC_ConfigController();
        public DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.CreateWaveController CreateWave = new DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.T4MVC_CreateWaveController();
        public DcmsMobile.PickWaves.Areas.PickWaves.Home.HomeController Home = new DcmsMobile.PickWaves.Areas.PickWaves.Home.T4MVC_HomeController();
        public DcmsMobile.PickWaves.Areas.PickWaves.ManageWaves.ManageWavesController ManageWaves = new DcmsMobile.PickWaves.Areas.PickWaves.ManageWaves.T4MVC_ManageWavesController();
        public T4MVC.PickWaves.SharedViewsController SharedViews = new T4MVC.PickWaves.SharedViewsController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_JsonResult : System.Web.Mvc.JsonResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links_PickWaves
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string jquery_2_1_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.min.js") ? Url("jquery-2.1.1.min.js") : Url("jquery-2.1.1.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_unobtrusive_bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.bootstrap.min.js") ? Url("jquery.validate.unobtrusive.bootstrap.min.js") : Url("jquery.validate.unobtrusive.bootstrap.js");
        public static readonly string jquery_validate_unobtrusive_bootstrap_min_js_map = Url("jquery.validate.unobtrusive.bootstrap.min.js.map");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string npm_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/npm.min.js") ? Url("npm.min.js") : Url("npm.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
             
        public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
             
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
    }


    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Areas {
        private const string URLPATH = "~/Areas";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class PickWaves {
            private const string URLPATH = "~/Areas/PickWaves";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class AutoComplete {
                private const string URLPATH = "~/Areas/PickWaves/AutoComplete";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string AutoComplete_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AutoComplete.partial.min.js") ? Url("AutoComplete.partial.min.js") : Url("AutoComplete.partial.js");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class PickWaves {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class BoxPickPallet {
                private const string URLPATH = "~/Areas/PickWaves/BoxPickPallet";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string BoxPickPalletIndex_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/BoxPickPalletIndex-all.min.js") ? Url("BoxPickPalletIndex-all.min.js") : Url("BoxPickPalletIndex-all.js");
                public static readonly string BoxPickPalletIndex_all_min_js_map = Url("BoxPickPalletIndex-all.min.js.map");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class PickWaves {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Config {
                private const string URLPATH = "~/Areas/PickWaves/Config";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Config_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Config.min.css") ? Url("Config.min.css") : Url("Config.css");
                     
                public static readonly string Config_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Config.min.js") ? Url("Config.min.js") : Url("Config.js");
                public static readonly string Config_min_js_map = Url("Config.min.js.map");
                public static readonly string Config_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Config.partial.min.js") ? Url("Config.partial.min.js") : Url("Config.partial.js");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class DisplayTemplates {
                    private const string URLPATH = "~/Areas/PickWaves/Config/DisplayTemplates";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                public static readonly string ManageSkuCase_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageSkuCase.min.js") ? Url("ManageSkuCase.min.js") : Url("ManageSkuCase.js");
                public static readonly string ManageSkuCase_min_js_map = Url("ManageSkuCase.min.js.map");
                public static readonly string ManageSkuCase_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageSkuCase.partial.min.js") ? Url("ManageSkuCase.partial.min.js") : Url("ManageSkuCase.partial.js");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class PickWaves {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class CreateWave {
                private const string URLPATH = "~/Areas/PickWaves/CreateWave";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class PickWaves {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Home {
                private const string URLPATH = "~/Areas/PickWaves/Home";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class PickWaves {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class ManageWaves {
                private const string URLPATH = "~/Areas/PickWaves/ManageWaves";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Index_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Index.min.js") ? Url("Index.min.js") : Url("Index.js");
                public static readonly string ManageWave_Wave_partial_O_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageWave-Wave.partial_O.min.js") ? Url("ManageWave-Wave.partial_O.min.js") : Url("ManageWave-Wave.partial_O.js");
                public static readonly string ManageWave_Wave_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageWave-Wave.min.js") ? Url("ManageWave-Wave.min.js") : Url("ManageWave-Wave.js");
                public static readonly string ManageWave_Wave_min_js_map = Url("ManageWave-Wave.min.js.map");
                public static readonly string Wave_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Wave.min.js") ? Url("Wave.min.js") : Url("Wave.js");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class PickWaves {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class SharedViews {
                private const string URLPATH = "~/Areas/PickWaves/SharedViews";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string _bucketModel_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_bucketModel.partial.min.js") ? Url("_bucketModel.partial.min.js") : Url("_bucketModel.partial.js");
                public static readonly string ajax_loader_gif = Url("ajax-loader.gif");
                public static readonly string jQuery_cookie_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jQuery.cookie.partial.min.js") ? Url("jQuery.cookie.partial.min.js") : Url("jQuery.cookie.partial.js");
            }
        
        }
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009


