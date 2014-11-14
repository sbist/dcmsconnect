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
        public DcmsMobile.PickWaves.Areas.PickWaves.Controllers.CreateWaveController CreateWave = new DcmsMobile.PickWaves.Areas.PickWaves.Controllers.T4MVC_CreateWaveController();
        public DcmsMobile.PickWaves.Areas.PickWaves.Controllers.HomeController Home = new DcmsMobile.PickWaves.Areas.PickWaves.Controllers.T4MVC_HomeController();
        public DcmsMobile.PickWaves.Areas.PickWaves.Controllers.ManageWavesController ManageWaves = new DcmsMobile.PickWaves.Areas.PickWaves.Controllers.T4MVC_ManageWavesController();
        public T4MVC.PickWaves.o_ScriptsController o_Scripts = new T4MVC.PickWaves.o_ScriptsController();
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
        public static readonly string jquery_2_1_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.min.js") ? Url("jquery-2.1.1.min.js") : Url("jquery-2.1.1.js");
        public static readonly string jquery_ui_1_10_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.0.min.js") ? Url("jquery-ui-1.10.0.min.js") : Url("jquery-ui-1.10.0.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
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
            public static class @base {
                private const string URLPATH = "~/Content/themes/base";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/base/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string animated_overlay_gif = Url("animated-overlay.gif");
                }
            
                public static readonly string jquery_ui_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui.min.css") ? Url("jquery-ui.min.css") : Url("jquery-ui.css");
                     
                public static readonly string jquery_ui_accordion_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.accordion.min.css") ? Url("jquery.ui.accordion.min.css") : Url("jquery.ui.accordion.css");
                     
                public static readonly string jquery_ui_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.all.min.css") ? Url("jquery.ui.all.min.css") : Url("jquery.ui.all.css");
                     
                public static readonly string jquery_ui_autocomplete_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.autocomplete.min.css") ? Url("jquery.ui.autocomplete.min.css") : Url("jquery.ui.autocomplete.css");
                     
                public static readonly string jquery_ui_base_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.base.min.css") ? Url("jquery.ui.base.min.css") : Url("jquery.ui.base.css");
                     
                public static readonly string jquery_ui_button_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.button.min.css") ? Url("jquery.ui.button.min.css") : Url("jquery.ui.button.css");
                     
                public static readonly string jquery_ui_core_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.core.min.css") ? Url("jquery.ui.core.min.css") : Url("jquery.ui.core.css");
                     
                public static readonly string jquery_ui_datepicker_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.datepicker.min.css") ? Url("jquery.ui.datepicker.min.css") : Url("jquery.ui.datepicker.css");
                     
                public static readonly string jquery_ui_dialog_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.dialog.min.css") ? Url("jquery.ui.dialog.min.css") : Url("jquery.ui.dialog.css");
                     
                public static readonly string jquery_ui_menu_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.menu.min.css") ? Url("jquery.ui.menu.min.css") : Url("jquery.ui.menu.css");
                     
                public static readonly string jquery_ui_progressbar_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.progressbar.min.css") ? Url("jquery.ui.progressbar.min.css") : Url("jquery.ui.progressbar.css");
                     
                public static readonly string jquery_ui_resizable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.resizable.min.css") ? Url("jquery.ui.resizable.min.css") : Url("jquery.ui.resizable.css");
                     
                public static readonly string jquery_ui_selectable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.selectable.min.css") ? Url("jquery.ui.selectable.min.css") : Url("jquery.ui.selectable.css");
                     
                public static readonly string jquery_ui_slider_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.slider.min.css") ? Url("jquery.ui.slider.min.css") : Url("jquery.ui.slider.css");
                     
                public static readonly string jquery_ui_spinner_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.spinner.min.css") ? Url("jquery.ui.spinner.min.css") : Url("jquery.ui.spinner.css");
                     
                public static readonly string jquery_ui_tabs_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.tabs.min.css") ? Url("jquery.ui.tabs.min.css") : Url("jquery.ui.tabs.css");
                     
                public static readonly string jquery_ui_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.theme.min.css") ? Url("jquery.ui.theme.min.css") : Url("jquery.ui.theme.css");
                     
                public static readonly string jquery_ui_tooltip_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.tooltip.min.css") ? Url("jquery.ui.tooltip.min.css") : Url("jquery.ui.tooltip.css");
                     
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class minified {
                    private const string URLPATH = "~/Content/themes/base/minified";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                    public static class images {
                        private const string URLPATH = "~/Content/themes/base/minified/images";
                        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                        public static readonly string animated_overlay_gif = Url("animated-overlay.gif");
                    }
                
                }
            
            }
        
        }
    
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
                public static readonly string CreateWave_Index_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CreateWave-Index.min.css") ? Url("CreateWave-Index.min.css") : Url("CreateWave-Index.css");
                     
                public static readonly string CreateWave_Index_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CreateWave-Index.min.js") ? Url("CreateWave-Index.min.js") : Url("CreateWave-Index.js");
                public static readonly string CreateWave_Index_min_js_map = Url("CreateWave-Index.min.js.map");
                public static readonly string CreateWave_Index_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CreateWave-Index.partial.min.js") ? Url("CreateWave-Index.partial.min.js") : Url("CreateWave-Index.partial.js");
                public static readonly string CreateWave_PickslipList_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CreateWave-PickslipList.min.css") ? Url("CreateWave-PickslipList.min.css") : Url("CreateWave-PickslipList.css");
                     
                public static readonly string CreateWave_PickslipList_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CreateWave-PickslipList.min.js") ? Url("CreateWave-PickslipList.min.js") : Url("CreateWave-PickslipList.js");
                public static readonly string CreateWave_PickslipList_min_js_map = Url("CreateWave-PickslipList.min.js.map");
                public static readonly string CreateWave_PickslipList_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CreateWave-PickslipList.partial.min.js") ? Url("CreateWave-PickslipList.partial.min.js") : Url("CreateWave-PickslipList.partial.js");
                public static readonly string CreateWave_PickslipListSelector_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CreateWave-PickslipListSelector.min.css") ? Url("CreateWave-PickslipListSelector.min.css") : Url("CreateWave-PickslipListSelector.css");
                     
                public static readonly string selectable_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/selectable.partial.min.js") ? Url("selectable.partial.min.js") : Url("selectable.partial.js");
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
                public static readonly string Home_CustomerSummary_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Home-CustomerSummary.min.css") ? Url("Home-CustomerSummary.min.css") : Url("Home-CustomerSummary.css");
                     
                public static readonly string Home_Index_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Home-Index.min.css") ? Url("Home-Index.min.css") : Url("Home-Index.css");
                     
                public static readonly string Home_Index_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Home-Index.min.js") ? Url("Home-Index.min.js") : Url("Home-Index.js");
                public static readonly string Home_Index_min_js_map = Url("Home-Index.min.js.map");
                public static readonly string Home_Index_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Home-Index.partial.min.js") ? Url("Home-Index.partial.min.js") : Url("Home-Index.partial.js");
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
                public static readonly string ManageWave_Index_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageWave-Index.min.css") ? Url("ManageWave-Index.min.css") : Url("ManageWave-Index.css");
                     
                public static readonly string ManageWave_Index_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageWave-Index.min.js") ? Url("ManageWave-Index.min.js") : Url("ManageWave-Index.js");
                public static readonly string ManageWave_Index_min_js_map = Url("ManageWave-Index.min.js.map");
                public static readonly string ManageWave_Index_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageWave-Index.partial.min.js") ? Url("ManageWave-Index.partial.min.js") : Url("ManageWave-Index.partial.js");
                public static readonly string ManageWave_Wave_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageWave-Wave.min.css") ? Url("ManageWave-Wave.min.css") : Url("ManageWave-Wave.css");
                     
                public static readonly string ManageWave_Wave_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageWave-Wave.min.js") ? Url("ManageWave-Wave.min.js") : Url("ManageWave-Wave.js");
                public static readonly string ManageWave_Wave_min_js_map = Url("ManageWave-Wave.min.js.map");
                public static readonly string ManageWave_Wave_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageWave-Wave.partial.min.js") ? Url("ManageWave-Wave.partial.min.js") : Url("ManageWave-Wave.partial.js");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class PickWaves {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class o_Scripts {
                private const string URLPATH = "~/Areas/PickWaves/o_Scripts";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
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
                public static readonly string ajax_loader_gif = Url("ajax-loader.gif");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class DisplayTemplates {
                    private const string URLPATH = "~/Areas/PickWaves/SharedViews/DisplayTemplates";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string _bucketEditorPartial_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_bucketEditorPartial.partial.min.js") ? Url("_bucketEditorPartial.partial.min.js") : Url("_bucketEditorPartial.partial.js");
                    public static readonly string bucketModel_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bucketModel.partial.min.js") ? Url("bucketModel.partial.min.js") : Url("bucketModel.partial.js");
                }
            
                public static readonly string jQuery_cookie_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jQuery.cookie.partial.min.js") ? Url("jQuery.cookie.partial.min.js") : Url("jQuery.cookie.partial.js");
                public static readonly string PickWaves_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PickWaves-all.min.css") ? Url("PickWaves-all.min.css") : Url("PickWaves-all.css");
                     
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
