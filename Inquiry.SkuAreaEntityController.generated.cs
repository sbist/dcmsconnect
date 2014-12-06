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
namespace DcmsMobile.Inquiry.Areas.Inquiry.SkuAreaEntity
{
    public partial class SkuAreaEntityController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SkuAreaEntityController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SkuAreaEntityController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult SKUArea()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SKUArea);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SkuLocation()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuLocation);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.PartialViewResult LocationAudit()
        {
            return new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames.LocationAudit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.PartialViewResult SkuAssignmentAudit()
        {
            return new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames.SkuAssignmentAudit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SkuLocationExcel()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuLocationExcel);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SkuAreaEntityController Actions { get { return MVC_Inquiry.Inquiry.SkuAreaEntity; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Inquiry";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "SkuAreaEntity";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "SkuAreaEntity";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string SKUArea = "SKUArea";
            public readonly string SkuLocation = "SkuLocation";
            public readonly string LocationAudit = "LocationAudit";
            public readonly string SkuAssignmentAudit = "SkuAssignmentAudit";
            public readonly string SkuLocationExcel = "SkuLocationExcel";
            public readonly string SKUAreaList = "SKUAreaList";
            public readonly string SkuLocationList = "SkuLocationList";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string SKUArea = "SKUArea";
            public const string SkuLocation = "SkuLocation";
            public const string LocationAudit = "LocationAudit";
            public const string SkuAssignmentAudit = "SkuAssignmentAudit";
            public const string SkuLocationExcel = "SkuLocationExcel";
            public const string SKUAreaList = "SKUAreaList";
            public const string SkuLocationList = "SkuLocationList";
        }


        static readonly ActionParamsClass_SKUArea s_params_SKUArea = new ActionParamsClass_SKUArea();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SKUArea SKUAreaParams { get { return s_params_SKUArea; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SKUArea
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_SkuLocation s_params_SkuLocation = new ActionParamsClass_SkuLocation();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SkuLocation SkuLocationParams { get { return s_params_SkuLocation; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SkuLocation
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_LocationAudit s_params_LocationAudit = new ActionParamsClass_LocationAudit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_LocationAudit LocationAuditParams { get { return s_params_LocationAudit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_LocationAudit
        {
            public readonly string locationId = "locationId";
        }
        static readonly ActionParamsClass_SkuAssignmentAudit s_params_SkuAssignmentAudit = new ActionParamsClass_SkuAssignmentAudit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SkuAssignmentAudit SkuAssignmentAuditParams { get { return s_params_SkuAssignmentAudit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SkuAssignmentAudit
        {
            public readonly string locationId = "locationId";
        }
        static readonly ActionParamsClass_SkuLocationExcel s_params_SkuLocationExcel = new ActionParamsClass_SkuLocationExcel();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SkuLocationExcel SkuLocationExcelParams { get { return s_params_SkuLocationExcel; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SkuLocationExcel
        {
            public readonly string id = "id";
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
                public readonly string _locationAuditPartial = "_locationAuditPartial";
                public readonly string _SkuAssignmentAuditPartial = "_SkuAssignmentAuditPartial";
                public readonly string SKUArea = "SKUArea";
                public readonly string SKUAreaList = "SKUAreaList";
                public readonly string SkuLocation = "SkuLocation";
                public readonly string SkuLocationList = "SkuLocationList";
            }
            public readonly string _locationAuditPartial = "~/Areas/Inquiry/SkuAreaEntity/_locationAuditPartial.cshtml";
            public readonly string _SkuAssignmentAuditPartial = "~/Areas/Inquiry/SkuAreaEntity/_SkuAssignmentAuditPartial.cshtml";
            public readonly string SKUArea = "~/Areas/Inquiry/SkuAreaEntity/SKUArea.cshtml";
            public readonly string SKUAreaList = "~/Areas/Inquiry/SkuAreaEntity/SKUAreaList.cshtml";
            public readonly string SkuLocation = "~/Areas/Inquiry/SkuAreaEntity/SkuLocation.cshtml";
            public readonly string SkuLocationList = "~/Areas/Inquiry/SkuAreaEntity/SkuLocationList.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SkuAreaEntityController : DcmsMobile.Inquiry.Areas.Inquiry.SkuAreaEntity.SkuAreaEntityController
    {
        public T4MVC_SkuAreaEntityController() : base(Dummy.Instance) { }

        [NonAction]
        partial void SKUAreaOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult SKUArea(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SKUArea);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            SKUAreaOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void SkuLocationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult SkuLocation(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuLocation);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            SkuLocationOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void LocationAuditOverride(T4MVC_System_Web_Mvc_PartialViewResult callInfo, string locationId);

        [NonAction]
        public override System.Web.Mvc.PartialViewResult LocationAudit(string locationId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames.LocationAudit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "locationId", locationId);
            LocationAuditOverride(callInfo, locationId);
            return callInfo;
        }

        [NonAction]
        partial void SkuAssignmentAuditOverride(T4MVC_System_Web_Mvc_PartialViewResult callInfo, string locationId);

        [NonAction]
        public override System.Web.Mvc.PartialViewResult SkuAssignmentAudit(string locationId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames.SkuAssignmentAudit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "locationId", locationId);
            SkuAssignmentAuditOverride(callInfo, locationId);
            return callInfo;
        }

        [NonAction]
        partial void SkuLocationExcelOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult SkuLocationExcel(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuLocationExcel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            SkuLocationExcelOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void SKUAreaListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult SKUAreaList()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SKUAreaList);
            SKUAreaListOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SkuLocationListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult SkuLocationList()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuLocationList);
            SkuLocationListOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
