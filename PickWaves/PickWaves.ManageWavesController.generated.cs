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
namespace DcmsMobile.PickWaves.Areas.PickWaves.Controllers
{
    public partial class ManageWavesController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ManageWavesController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Wave()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wave);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EditableWave()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditableWave);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult WaveSkus()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveSkus);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult WaveBoxes()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveBoxes);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult WavePickslips()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WavePickslips);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EditWave()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditWave);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult IncrementPriority()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IncrementPriority);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DecrementPriority()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DecrementPriority);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult FreezeBucket()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FreezeBucket);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RemovePickslipFromBucket()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemovePickslipFromBucket);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ManageWavesController Actions { get { return MVC_PickWaves.PickWaves.ManageWaves; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "PickWaves";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "ManageWaves";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "ManageWaves";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Wave = "Wave";
            public readonly string EditableWave = "EditableWave";
            public readonly string WaveSkus = "WaveSkus";
            public readonly string WaveBoxes = "WaveBoxes";
            public readonly string WavePickslips = "WavePickslips";
            public readonly string EditWave = "EditWave";
            public readonly string IncrementPriority = "IncrementPriority";
            public readonly string DecrementPriority = "DecrementPriority";
            public readonly string FreezeBucket = "FreezeBucket";
            public readonly string RemovePickslipFromBucket = "RemovePickslipFromBucket";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Wave = "Wave";
            public const string EditableWave = "EditableWave";
            public const string WaveSkus = "WaveSkus";
            public const string WaveBoxes = "WaveBoxes";
            public const string WavePickslips = "WavePickslips";
            public const string EditWave = "EditWave";
            public const string IncrementPriority = "IncrementPriority";
            public const string DecrementPriority = "DecrementPriority";
            public const string FreezeBucket = "FreezeBucket";
            public const string RemovePickslipFromBucket = "RemovePickslipFromBucket";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Wave s_params_Wave = new ActionParamsClass_Wave();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Wave WaveParams { get { return s_params_Wave; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Wave
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_EditableWave s_params_EditableWave = new ActionParamsClass_EditableWave();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditableWave EditableWaveParams { get { return s_params_EditableWave; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditableWave
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_WaveSkus s_params_WaveSkus = new ActionParamsClass_WaveSkus();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_WaveSkus WaveSkusParams { get { return s_params_WaveSkus; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_WaveSkus
        {
            public readonly string bucketId = "bucketId";
            public readonly string stateFilter = "stateFilter";
            public readonly string activityFilter = "activityFilter";
        }
        static readonly ActionParamsClass_WaveBoxes s_params_WaveBoxes = new ActionParamsClass_WaveBoxes();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_WaveBoxes WaveBoxesParams { get { return s_params_WaveBoxes; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_WaveBoxes
        {
            public readonly string bucketId = "bucketId";
            public readonly string stateFilter = "stateFilter";
            public readonly string activityFilter = "activityFilter";
        }
        static readonly ActionParamsClass_WavePickslips s_params_WavePickslips = new ActionParamsClass_WavePickslips();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_WavePickslips WavePickslipsParams { get { return s_params_WavePickslips; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_WavePickslips
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_EditWave s_params_EditWave = new ActionParamsClass_EditWave();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditWave EditWaveParams { get { return s_params_EditWave; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditWave
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_IncrementPriority s_params_IncrementPriority = new ActionParamsClass_IncrementPriority();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_IncrementPriority IncrementPriorityParams { get { return s_params_IncrementPriority; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_IncrementPriority
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_DecrementPriority s_params_DecrementPriority = new ActionParamsClass_DecrementPriority();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DecrementPriority DecrementPriorityParams { get { return s_params_DecrementPriority; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DecrementPriority
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_FreezeBucket s_params_FreezeBucket = new ActionParamsClass_FreezeBucket();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_FreezeBucket FreezeBucketParams { get { return s_params_FreezeBucket; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_FreezeBucket
        {
            public readonly string bucketId = "bucketId";
            public readonly string freeze = "freeze";
            public readonly string displayEditable = "displayEditable";
        }
        static readonly ActionParamsClass_RemovePickslipFromBucket s_params_RemovePickslipFromBucket = new ActionParamsClass_RemovePickslipFromBucket();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RemovePickslipFromBucket RemovePickslipFromBucketParams { get { return s_params_RemovePickslipFromBucket; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RemovePickslipFromBucket
        {
            public readonly string bucketId = "bucketId";
            public readonly string pickslipId = "pickslipId";
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
                public readonly string _bucketEditorPartial = "_bucketEditorPartial";
                public readonly string _waveBoxesPartial = "_waveBoxesPartial";
                public readonly string _wavePickslipsPartial = "_wavePickslipsPartial";
                public readonly string _waveSkusPartial = "_waveSkusPartial";
                public readonly string Index = "Index";
                public readonly string ManageWave_Index_css = "ManageWave-Index.css";
                public readonly string ManageWave_Index_js = "ManageWave-Index.js";
                public readonly string ManageWave_Wave_css = "ManageWave-Wave.css";
                public readonly string ManageWave_Wave_js = "ManageWave-Wave.js";
                public readonly string Wave = "Wave";
            }
            public readonly string _bucketEditorPartial = "~/Areas/PickWaves/ManageWaves/_bucketEditorPartial.cshtml";
            public readonly string _waveBoxesPartial = "~/Areas/PickWaves/ManageWaves/_waveBoxesPartial.cshtml";
            public readonly string _wavePickslipsPartial = "~/Areas/PickWaves/ManageWaves/_wavePickslipsPartial.cshtml";
            public readonly string _waveSkusPartial = "~/Areas/PickWaves/ManageWaves/_waveSkusPartial.cshtml";
            public readonly string Index = "~/Areas/PickWaves/ManageWaves/Index.cshtml";
            public readonly string ManageWave_Index_css = "~/Areas/PickWaves/ManageWaves/ManageWave-Index.css.bundle";
            public readonly string ManageWave_Index_js = "~/Areas/PickWaves/ManageWaves/ManageWave-Index.js.bundle";
            public readonly string ManageWave_Wave_css = "~/Areas/PickWaves/ManageWaves/ManageWave-Wave.css.bundle";
            public readonly string ManageWave_Wave_js = "~/Areas/PickWaves/ManageWaves/ManageWave-Wave.js.bundle";
            public readonly string Wave = "~/Areas/PickWaves/ManageWaves/Wave.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ManageWavesController : DcmsMobile.PickWaves.Areas.PickWaves.Controllers.ManageWavesController
    {
        public T4MVC_ManageWavesController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.ViewModels.ManageWaves.IndexViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(DcmsMobile.PickWaves.ViewModels.ManageWaves.IndexViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            IndexOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void WaveOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.ViewModels.ManageWaves.WaveViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wave(DcmsMobile.PickWaves.ViewModels.ManageWaves.WaveViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wave);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            WaveOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void EditableWaveOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.ViewModels.ManageWaves.WaveViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult EditableWave(DcmsMobile.PickWaves.ViewModels.ManageWaves.WaveViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditableWave);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditableWaveOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void WaveSkusOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId, DcmsMobile.PickWaves.Helpers.BoxState stateFilter, DcmsMobile.PickWaves.Helpers.BucketActivityType activityFilter);

        [NonAction]
        public override System.Web.Mvc.ActionResult WaveSkus(int bucketId, DcmsMobile.PickWaves.Helpers.BoxState stateFilter, DcmsMobile.PickWaves.Helpers.BucketActivityType activityFilter)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveSkus);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "stateFilter", stateFilter);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "activityFilter", activityFilter);
            WaveSkusOverride(callInfo, bucketId, stateFilter, activityFilter);
            return callInfo;
        }

        [NonAction]
        partial void WaveBoxesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId, DcmsMobile.PickWaves.Helpers.BoxState stateFilter, DcmsMobile.PickWaves.Helpers.BucketActivityType activityFilter);

        [NonAction]
        public override System.Web.Mvc.ActionResult WaveBoxes(int bucketId, DcmsMobile.PickWaves.Helpers.BoxState stateFilter, DcmsMobile.PickWaves.Helpers.BucketActivityType activityFilter)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveBoxes);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "stateFilter", stateFilter);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "activityFilter", activityFilter);
            WaveBoxesOverride(callInfo, bucketId, stateFilter, activityFilter);
            return callInfo;
        }

        [NonAction]
        partial void WavePickslipsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult WavePickslips(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WavePickslips);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            WavePickslipsOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void EditWaveOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.ViewModels.ManageWaves.WaveViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult EditWave(DcmsMobile.PickWaves.ViewModels.ManageWaves.WaveViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditWave);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditWaveOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void IncrementPriorityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult IncrementPriority(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IncrementPriority);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            IncrementPriorityOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void DecrementPriorityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult DecrementPriority(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DecrementPriority);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            DecrementPriorityOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void FreezeBucketOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId, bool freeze, bool displayEditable);

        [NonAction]
        public override System.Web.Mvc.ActionResult FreezeBucket(int bucketId, bool freeze, bool displayEditable)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FreezeBucket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "freeze", freeze);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "displayEditable", displayEditable);
            FreezeBucketOverride(callInfo, bucketId, freeze, displayEditable);
            return callInfo;
        }

        [NonAction]
        partial void RemovePickslipFromBucketOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId, long pickslipId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RemovePickslipFromBucket(int bucketId, long pickslipId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemovePickslipFromBucket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pickslipId", pickslipId);
            RemovePickslipFromBucketOverride(callInfo, bucketId, pickslipId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
