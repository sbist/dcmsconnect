// <auto-generated />
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
namespace DcmsMobile.Receiving.Areas.Receiving.Rad
{
    public partial class RadController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RadController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddUpdateSpotCheckSetting()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddUpdateSpotCheckSetting);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult StyleAutocomplete()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.StyleAutocomplete);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public RadController Actions { get { return MVC_Receiving.Receiving.Rad; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Receiving";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Rad";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Rad";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string AddSpotCheckPartial = "AddSpotCheckPartial";
            public readonly string AddUpdateSpotCheckSetting = "AddUpdateSpotCheckSetting";
            public readonly string StyleAutocomplete = "StyleAutocomplete";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string AddSpotCheckPartial = "AddSpotCheckPartial";
            public const string AddUpdateSpotCheckSetting = "AddUpdateSpotCheckSetting";
            public const string StyleAutocomplete = "StyleAutocomplete";
        }


        static readonly ActionParamsClass_AddUpdateSpotCheckSetting s_params_AddUpdateSpotCheckSetting = new ActionParamsClass_AddUpdateSpotCheckSetting();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddUpdateSpotCheckSetting AddUpdateSpotCheckSettingParams { get { return s_params_AddUpdateSpotCheckSetting; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddUpdateSpotCheckSetting
        {
            public readonly string action = "action";
            public readonly string style = "style";
            public readonly string color = "color";
            public readonly string sewingPlantId = "sewingPlantId";
            public readonly string spotCheckPercent = "spotCheckPercent";
            public readonly string enabled = "enabled";
        }
        static readonly ActionParamsClass_StyleAutocomplete s_params_StyleAutocomplete = new ActionParamsClass_StyleAutocomplete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_StyleAutocomplete StyleAutocompleteParams { get { return s_params_StyleAutocomplete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_StyleAutocomplete
        {
            public readonly string term = "term";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _addSpotCheckPartial = "_addSpotCheckPartial";
                public readonly string _indexListPartial = "_indexListPartial";
                public readonly string Index = "Index";
                public readonly string Index_js = "Index.js";
            }
            public readonly string _addSpotCheckPartial = "~/Areas/Receiving/Rad/_addSpotCheckPartial.cshtml";
            public readonly string _indexListPartial = "~/Areas/Receiving/Rad/_indexListPartial.cshtml";
            public readonly string Index = "~/Areas/Receiving/Rad/Index.cshtml";
            public readonly string Index_js = "~/Areas/Receiving/Rad/Index.js.bundle";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_RadController : DcmsMobile.Receiving.Areas.Receiving.Rad.RadController
    {
        public T4MVC_RadController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AddSpotCheckPartialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddSpotCheckPartial()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddSpotCheckPartial);
            AddSpotCheckPartialOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AddUpdateSpotCheckSettingOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.Receiving.Areas.Receiving.Rad.ModifyAction action, string style, string color, string sewingPlantId, int? spotCheckPercent, bool enabled);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddUpdateSpotCheckSetting(DcmsMobile.Receiving.Areas.Receiving.Rad.ModifyAction action, string style, string color, string sewingPlantId, int? spotCheckPercent, bool enabled)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddUpdateSpotCheckSetting);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "action", action);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "style", style);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "color", color);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sewingPlantId", sewingPlantId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "spotCheckPercent", spotCheckPercent);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "enabled", enabled);
            AddUpdateSpotCheckSettingOverride(callInfo, action, style, color, sewingPlantId, spotCheckPercent, enabled);
            return callInfo;
        }

        [NonAction]
        partial void StyleAutocompleteOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string term);

        [NonAction]
        public override System.Web.Mvc.JsonResult StyleAutocomplete(string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.StyleAutocomplete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            StyleAutocompleteOverride(callInfo, term);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
