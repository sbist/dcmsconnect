﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
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
public static partial class MVC_DcmsLite
{
    static readonly DcmsLiteClass s_DcmsLite = new DcmsLiteClass();
    public static DcmsLiteClass DcmsLite { get { return s_DcmsLite; } }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class DcmsLiteClass
    {
        public readonly string Name = "DcmsLite";
        public DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.HomeController Home = new DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.T4MVC_HomeController();
        public DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.PickController Pick = new DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.T4MVC_PickController();
        public DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.ReceiveController Receive = new DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.T4MVC_ReceiveController();
        public DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.ShipController Ship = new DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.T4MVC_ShipController();
        public DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.ValidationController Validation = new DcmsMobile.DcmsLite.Areas.DcmsLite.Controllers.T4MVC_ValidationController();
        public T4MVC.DcmsLite.SharedController Shared = new T4MVC.DcmsLite.SharedController();
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



namespace Links_DcmsLite
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string jquery_2_0_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.0.3.min.js") ? Url("jquery-2.0.3.min.js") : Url("jquery-2.0.3.js");
        public static readonly string jquery_2_0_3_min_js = Url("jquery-2.0.3.min.js");
        public static readonly string jquery_ui_1_10_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.0.min.js") ? Url("jquery-ui-1.10.0.min.js") : Url("jquery-ui-1.10.0.js");
        public static readonly string jquery_ui_1_10_0_min_js = Url("jquery-ui-1.10.0.min.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class themes {
            private const string URLPATH = "~/Content/themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Start1_10_0 {
                private const string URLPATH = "~/Content/themes/Start1.10.0";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/Start1.10.0/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string ui_bg_flat_55_999999_40x100_png = Url("ui-bg_flat_55_999999_40x100.png");
                    public static readonly string ui_bg_flat_75_aaaaaa_40x100_png = Url("ui-bg_flat_75_aaaaaa_40x100.png");
                    public static readonly string ui_bg_glass_45_0078ae_1x400_png = Url("ui-bg_glass_45_0078ae_1x400.png");
                    public static readonly string ui_bg_glass_55_f8da4e_1x400_png = Url("ui-bg_glass_55_f8da4e_1x400.png");
                    public static readonly string ui_bg_glass_75_79c9ec_1x400_png = Url("ui-bg_glass_75_79c9ec_1x400.png");
                    public static readonly string ui_bg_gloss_wave_45_e14f1c_500x100_png = Url("ui-bg_gloss-wave_45_e14f1c_500x100.png");
                    public static readonly string ui_bg_gloss_wave_50_6eac2c_500x100_png = Url("ui-bg_gloss-wave_50_6eac2c_500x100.png");
                    public static readonly string ui_bg_gloss_wave_75_2191c0_500x100_png = Url("ui-bg_gloss-wave_75_2191c0_500x100.png");
                    public static readonly string ui_bg_inset_hard_100_fcfdfd_1x100_png = Url("ui-bg_inset-hard_100_fcfdfd_1x100.png");
                    public static readonly string ui_icons_0078ae_256x240_png = Url("ui-icons_0078ae_256x240.png");
                    public static readonly string ui_icons_056b93_256x240_png = Url("ui-icons_056b93_256x240.png");
                    public static readonly string ui_icons_d8e7f3_256x240_png = Url("ui-icons_d8e7f3_256x240.png");
                    public static readonly string ui_icons_e0fdff_256x240_png = Url("ui-icons_e0fdff_256x240.png");
                    public static readonly string ui_icons_f5e175_256x240_png = Url("ui-icons_f5e175_256x240.png");
                    public static readonly string ui_icons_f7a50d_256x240_png = Url("ui-icons_f7a50d_256x240.png");
                    public static readonly string ui_icons_fcd113_256x240_png = Url("ui-icons_fcd113_256x240.png");
                }
            
                public static readonly string jquery_ui_min_css = Url("jquery-ui.min.css");
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Areas {
        private const string URLPATH = "~/Areas";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class DcmsLite {
            private const string URLPATH = "~/Areas/DcmsLite";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Content {
                private const string URLPATH = "~/Areas/DcmsLite/Content";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string _3PLDCMS_V3_pptx = Url("3PLDCMS V3.pptx");
                public static readonly string DcmsLite_all_css_bundle = Url("DcmsLite-all.css.bundle");
                public static readonly string DcmsLite_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/DcmsLite-all.min.css") ? Url("DcmsLite-all.min.css") : Url("DcmsLite-all.css");
                     
                public static readonly string DcmsLite_all_min_css = Url("DcmsLite-all.min.css");
                public static readonly string DcmsLite_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/DcmsLite.partial.min.css") ? Url("DcmsLite.partial.min.css") : Url("DcmsLite.partial.css");
                     
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Areas/DcmsLite/Content/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string a1_gif = Url("a1.gif");
                    public static readonly string ajax_loader_gif = Url("ajax-loader.gif");
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Sounds {
                    private const string URLPATH = "~/Areas/DcmsLite/Content/Sounds";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string Error_wav = Url("Error.wav");
                    public static readonly string success_wav = Url("success.wav");
                    public static readonly string warning_wav = Url("warning.wav");
                }
            
                public static readonly string standardized_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/standardized.partial.min.css") ? Url("standardized.partial.min.css") : Url("standardized.partial.css");
                     
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Controllers {
                private const string URLPATH = "~/Areas/DcmsLite/Controllers";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Scripts {
                private const string URLPATH = "~/Areas/DcmsLite/Scripts";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Batch_js_bundle = Url("Batch.js.bundle");
                public static readonly string Batch_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Batch.min.js") ? Url("Batch.min.js") : Url("Batch.js");
                public static readonly string Batch_min_js = Url("Batch.min.js");
                public static readonly string Batch_min_js_map = Url("Batch.min.js.map");
                public static readonly string Batch_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Batch.partial.min.js") ? Url("Batch.partial.min.js") : Url("Batch.partial.js");
                public static readonly string layout_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/layout.min.js") ? Url("layout.min.js") : Url("layout.js");
                public static readonly string layout_min_js = Url("layout.min.js");
                public static readonly string layout_min_js_map = Url("layout.min.js.map");
                public static readonly string Receive_js_bundle = Url("Receive.js.bundle");
                public static readonly string Receive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Receive.min.js") ? Url("Receive.min.js") : Url("Receive.js");
                public static readonly string Receive_min_js = Url("Receive.min.js");
                public static readonly string Receive_min_js_map = Url("Receive.min.js.map");
                public static readonly string Receive_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Receive.partial.min.js") ? Url("Receive.partial.min.js") : Url("Receive.partial.js");
                public static readonly string Wave_js_bundle = Url("Wave.js.bundle");
                public static readonly string Wave_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Wave.min.js") ? Url("Wave.min.js") : Url("Wave.js");
                public static readonly string Wave_min_js = Url("Wave.min.js");
                public static readonly string Wave_min_js_map = Url("Wave.min.js.map");
                public static readonly string Wave_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Wave.partial.min.js") ? Url("Wave.partial.min.js") : Url("Wave.partial.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Views {
                private const string URLPATH = "~/Areas/DcmsLite/Views";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Home {
                    private const string URLPATH = "~/Areas/DcmsLite/Views/Home";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Pick {
                    private const string URLPATH = "~/Areas/DcmsLite/Views/Pick";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Receive {
                    private const string URLPATH = "~/Areas/DcmsLite/Views/Receive";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Shared {
                    private const string URLPATH = "~/Areas/DcmsLite/Views/Shared";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Ship {
                    private const string URLPATH = "~/Areas/DcmsLite/Views/Ship";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Validation {
                    private const string URLPATH = "~/Areas/DcmsLite/Views/Validation";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                public static readonly string Web_config = Url("Web.config");
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
#pragma warning restore 1591


