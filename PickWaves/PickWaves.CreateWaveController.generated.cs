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
namespace DcmsMobile.PickWaves.Areas.PickWaves.CreateWave
{
    public partial class CreateWaveController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CreateWaveController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddPickslipsOfDim()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddPickslipsOfDim);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PickslipList()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PickslipList);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddPickslipsToBucket()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddPickslipsToBucket);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CreateWaveController Actions { get { return MVC_PickWaves.PickWaves.CreateWave; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "PickWaves";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "CreateWave";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "CreateWave";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string AddPickslipsOfDim = "AddPickslipsOfDim";
            public readonly string PickslipList = "PickslipList";
            public readonly string AddPickslipsToBucket = "AddPickslipsToBucket";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string AddPickslipsOfDim = "AddPickslipsOfDim";
            public const string PickslipList = "PickslipList";
            public const string AddPickslipsToBucket = "AddPickslipsToBucket";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_AddPickslipsOfDim s_params_AddPickslipsOfDim = new ActionParamsClass_AddPickslipsOfDim();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddPickslipsOfDim AddPickslipsOfDimParams { get { return s_params_AddPickslipsOfDim; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddPickslipsOfDim
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_PickslipList s_params_PickslipList = new ActionParamsClass_PickslipList();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PickslipList PickslipListParams { get { return s_params_PickslipList; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PickslipList
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_AddPickslipsToBucket s_params_AddPickslipsToBucket = new ActionParamsClass_AddPickslipsToBucket();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddPickslipsToBucket AddPickslipsToBucketParams { get { return s_params_AddPickslipsToBucket; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddPickslipsToBucket
        {
            public readonly string model = "model";
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
                public readonly string Index = "Index";
                public readonly string PickslipList = "PickslipList";
            }
            public readonly string Index = "~/Areas/PickWaves/CreateWave/Index.cshtml";
            public readonly string PickslipList = "~/Areas/PickWaves/CreateWave/PickslipList.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CreateWaveController : DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.CreateWaveController
    {
        public T4MVC_CreateWaveController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.IndexViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.IndexViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            IndexOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void AddPickslipsOfDimOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.IndexViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddPickslipsOfDim(DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.IndexViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddPickslipsOfDim);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            AddPickslipsOfDimOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void PickslipListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.PickslipListViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult PickslipList(DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.PickslipListViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PickslipList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            PickslipListOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void AddPickslipsToBucketOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.PickslipListViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddPickslipsToBucket(DcmsMobile.PickWaves.Areas.PickWaves.CreateWave.PickslipListViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddPickslipsToBucket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            AddPickslipsToBucketOverride(callInfo, model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
