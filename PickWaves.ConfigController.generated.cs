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
    public partial class ConfigController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ConfigController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult DeleteCustomerSkuCaseConstraint()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteCustomerSkuCaseConstraint);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddCustomerSkuCasePreference()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddCustomerSkuCasePreference);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddOrUpdateSkuCase()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddOrUpdateSkuCase);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SkuCase()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuCase);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult GetSkuCaseEditor()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetSkuCaseEditor);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CustSkuCasePreferenceEditor()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustSkuCasePreferenceEditor);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DelPackingRule()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DelPackingRule);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PackingRuleAddView()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PackingRuleAddView);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddPackingRule()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddPackingRule);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Constraint()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Constraint);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CustomerConstraintEditView()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustomerConstraintEditView);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateCustomerConstraints()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateCustomerConstraints);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CustomerAutocomplete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustomerAutocomplete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult StyleAutoComplete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.StyleAutoComplete);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ConfigController Actions { get { return MVC_PickWaves.PickWaves.Config; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "PickWaves";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Config";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Config";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string DeleteCustomerSkuCaseConstraint = "DeleteCustomerSkuCaseConstraint";
            public readonly string AddCustomerSkuCasePreference = "AddCustomerSkuCasePreference";
            public readonly string AddOrUpdateSkuCase = "AddOrUpdateSkuCase";
            public readonly string SkuCase = "SkuCase";
            public readonly string GetSkuCaseEditor = "GetSkuCaseEditor";
            public readonly string SkuCaseAddPartial = "SkuCaseAddPartial";
            public readonly string CustSkuCasePreferenceEditor = "CustSkuCasePreferenceEditor";
            public readonly string DelPackingRule = "DelPackingRule";
            public readonly string PackingRuleAddView = "PackingRuleAddView";
            public readonly string AddPackingRule = "AddPackingRule";
            public readonly string Constraint = "Constraint";
            public readonly string CustomerConstraintEditView = "CustomerConstraintEditView";
            public readonly string CustomerConstraintAddView = "CustomerConstraintAddView";
            public readonly string UpdateCustomerConstraints = "UpdateCustomerConstraints";
            public readonly string CustomerAutocomplete = "CustomerAutocomplete";
            public readonly string StyleAutoComplete = "StyleAutoComplete";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string DeleteCustomerSkuCaseConstraint = "DeleteCustomerSkuCaseConstraint";
            public const string AddCustomerSkuCasePreference = "AddCustomerSkuCasePreference";
            public const string AddOrUpdateSkuCase = "AddOrUpdateSkuCase";
            public const string SkuCase = "SkuCase";
            public const string GetSkuCaseEditor = "GetSkuCaseEditor";
            public const string SkuCaseAddPartial = "SkuCaseAddPartial";
            public const string CustSkuCasePreferenceEditor = "CustSkuCasePreferenceEditor";
            public const string DelPackingRule = "DelPackingRule";
            public const string PackingRuleAddView = "PackingRuleAddView";
            public const string AddPackingRule = "AddPackingRule";
            public const string Constraint = "Constraint";
            public const string CustomerConstraintEditView = "CustomerConstraintEditView";
            public const string CustomerConstraintAddView = "CustomerConstraintAddView";
            public const string UpdateCustomerConstraints = "UpdateCustomerConstraints";
            public const string CustomerAutocomplete = "CustomerAutocomplete";
            public const string StyleAutoComplete = "StyleAutoComplete";
        }


        static readonly ActionParamsClass_DeleteCustomerSkuCaseConstraint s_params_DeleteCustomerSkuCaseConstraint = new ActionParamsClass_DeleteCustomerSkuCaseConstraint();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteCustomerSkuCaseConstraint DeleteCustomerSkuCaseConstraintParams { get { return s_params_DeleteCustomerSkuCaseConstraint; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteCustomerSkuCaseConstraint
        {
            public readonly string caseId = "caseId";
            public readonly string customerId = "customerId";
            public readonly string activeTab = "activeTab";
        }
        static readonly ActionParamsClass_AddCustomerSkuCasePreference s_params_AddCustomerSkuCasePreference = new ActionParamsClass_AddCustomerSkuCasePreference();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddCustomerSkuCasePreference AddCustomerSkuCasePreferenceParams { get { return s_params_AddCustomerSkuCasePreference; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddCustomerSkuCasePreference
        {
            public readonly string model = "model";
            public readonly string activeTab = "activeTab";
        }
        static readonly ActionParamsClass_AddOrUpdateSkuCase s_params_AddOrUpdateSkuCase = new ActionParamsClass_AddOrUpdateSkuCase();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddOrUpdateSkuCase AddOrUpdateSkuCaseParams { get { return s_params_AddOrUpdateSkuCase; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddOrUpdateSkuCase
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_SkuCase s_params_SkuCase = new ActionParamsClass_SkuCase();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SkuCase SkuCaseParams { get { return s_params_SkuCase; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SkuCase
        {
            public readonly string activeTab = "activeTab";
        }
        static readonly ActionParamsClass_GetSkuCaseEditor s_params_GetSkuCaseEditor = new ActionParamsClass_GetSkuCaseEditor();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetSkuCaseEditor GetSkuCaseEditorParams { get { return s_params_GetSkuCaseEditor; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetSkuCaseEditor
        {
            public readonly string skuCaseId = "skuCaseId";
        }
        static readonly ActionParamsClass_CustSkuCasePreferenceEditor s_params_CustSkuCasePreferenceEditor = new ActionParamsClass_CustSkuCasePreferenceEditor();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CustSkuCasePreferenceEditor CustSkuCasePreferenceEditorParams { get { return s_params_CustSkuCasePreferenceEditor; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CustSkuCasePreferenceEditor
        {
            public readonly string customerId = "customerId";
        }
        static readonly ActionParamsClass_DelPackingRule s_params_DelPackingRule = new ActionParamsClass_DelPackingRule();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DelPackingRule DelPackingRuleParams { get { return s_params_DelPackingRule; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DelPackingRule
        {
            public readonly string style = "style";
            public readonly string caseId = "caseId";
            public readonly string activeTab = "activeTab";
        }
        static readonly ActionParamsClass_PackingRuleAddView s_params_PackingRuleAddView = new ActionParamsClass_PackingRuleAddView();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PackingRuleAddView PackingRuleAddViewParams { get { return s_params_PackingRuleAddView; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PackingRuleAddView
        {
            public readonly string style = "style";
            public readonly string caseId = "caseId";
            public readonly string ignoreFlag = "ignoreFlag";
        }
        static readonly ActionParamsClass_AddPackingRule s_params_AddPackingRule = new ActionParamsClass_AddPackingRule();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddPackingRule AddPackingRuleParams { get { return s_params_AddPackingRule; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddPackingRule
        {
            public readonly string model = "model";
            public readonly string activeTab = "activeTab";
        }
        static readonly ActionParamsClass_Constraint s_params_Constraint = new ActionParamsClass_Constraint();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Constraint ConstraintParams { get { return s_params_Constraint; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Constraint
        {
            public readonly string selectedTab = "selectedTab";
        }
        static readonly ActionParamsClass_CustomerConstraintEditView s_params_CustomerConstraintEditView = new ActionParamsClass_CustomerConstraintEditView();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CustomerConstraintEditView CustomerConstraintEditViewParams { get { return s_params_CustomerConstraintEditView; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CustomerConstraintEditView
        {
            public readonly string customerId = "customerId";
        }
        static readonly ActionParamsClass_UpdateCustomerConstraints s_params_UpdateCustomerConstraints = new ActionParamsClass_UpdateCustomerConstraints();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateCustomerConstraints UpdateCustomerConstraintsParams { get { return s_params_UpdateCustomerConstraints; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateCustomerConstraints
        {
            public readonly string customerId = "customerId";
            public readonly string constraints = "constraints";
            public readonly string activeTab = "activeTab";
        }
        static readonly ActionParamsClass_CustomerAutocomplete s_params_CustomerAutocomplete = new ActionParamsClass_CustomerAutocomplete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CustomerAutocomplete CustomerAutocompleteParams { get { return s_params_CustomerAutocomplete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CustomerAutocomplete
        {
            public readonly string term = "term";
        }
        static readonly ActionParamsClass_StyleAutoComplete s_params_StyleAutoComplete = new ActionParamsClass_StyleAutoComplete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_StyleAutoComplete StyleAutoCompleteParams { get { return s_params_StyleAutoComplete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_StyleAutoComplete
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
                public readonly string _addCustomerConstraintPartial = "_addCustomerConstraintPartial";
                public readonly string _addPackinRule_js = "_addPackinRule.js";
                public readonly string _addPackinRulePartial = "_addPackinRulePartial";
                public readonly string _custSkuCasePreferenceEditor_js = "_custSkuCasePreferenceEditor.js";
                public readonly string _custSkuCasePreferenceEditorPartial = "_custSkuCasePreferenceEditorPartial";
                public readonly string _skuCaseEditorPartial = "_skuCaseEditorPartial";
                public readonly string Config_js_O = "Config.js_O";
                public readonly string Constraint = "Constraint";
                public readonly string Index = "Index";
                public readonly string ManageSkuCase_js = "ManageSkuCase.js";
                public readonly string SkuCase = "SkuCase";
            }
            public readonly string _addCustomerConstraintPartial = "~/Areas/PickWaves/Config/_addCustomerConstraintPartial.cshtml";
            public readonly string _addPackinRule_js = "~/Areas/PickWaves/Config/_addPackinRule.js.bundle";
            public readonly string _addPackinRulePartial = "~/Areas/PickWaves/Config/_addPackinRulePartial.cshtml";
            public readonly string _custSkuCasePreferenceEditor_js = "~/Areas/PickWaves/Config/_custSkuCasePreferenceEditor.js.bundle";
            public readonly string _custSkuCasePreferenceEditorPartial = "~/Areas/PickWaves/Config/_custSkuCasePreferenceEditorPartial.cshtml";
            public readonly string _skuCaseEditorPartial = "~/Areas/PickWaves/Config/_skuCaseEditorPartial.cshtml";
            public readonly string Config_js_O = "~/Areas/PickWaves/Config/Config.js_O.bundle";
            public readonly string Constraint = "~/Areas/PickWaves/Config/Constraint.cshtml";
            public readonly string Index = "~/Areas/PickWaves/Config/Index.cshtml";
            public readonly string ManageSkuCase_js = "~/Areas/PickWaves/Config/ManageSkuCase.js.bundle";
            public readonly string SkuCase = "~/Areas/PickWaves/Config/SkuCase.cshtml";
            static readonly _DisplayTemplatesClass s_DisplayTemplates = new _DisplayTemplatesClass();
            public _DisplayTemplatesClass DisplayTemplates { get { return s_DisplayTemplates; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _DisplayTemplatesClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string ConstraintModel = "ConstraintModel";
                }
                public readonly string ConstraintModel = "~/Areas/PickWaves/Config/DisplayTemplates/ConstraintModel.cshtml";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ConfigController : DcmsMobile.PickWaves.Areas.PickWaves.Controllers.ConfigController
    {
        public T4MVC_ConfigController() : base(Dummy.Instance) { }

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
        partial void DeleteCustomerSkuCaseConstraintOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string caseId, string customerId, int? activeTab);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeleteCustomerSkuCaseConstraint(string caseId, string customerId, int? activeTab)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteCustomerSkuCaseConstraint);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "caseId", caseId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "customerId", customerId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "activeTab", activeTab);
            DeleteCustomerSkuCaseConstraintOverride(callInfo, caseId, customerId, activeTab);
            return callInfo;
        }

        [NonAction]
        partial void AddCustomerSkuCasePreferenceOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.ViewModels.Config.CustomerSkuCaseModel model, int? activeTab);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddCustomerSkuCasePreference(DcmsMobile.PickWaves.ViewModels.Config.CustomerSkuCaseModel model, int? activeTab)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddCustomerSkuCasePreference);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "activeTab", activeTab);
            AddCustomerSkuCasePreferenceOverride(callInfo, model, activeTab);
            return callInfo;
        }

        [NonAction]
        partial void AddOrUpdateSkuCaseOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.ViewModels.Config.SkuCaseModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddOrUpdateSkuCase(DcmsMobile.PickWaves.ViewModels.Config.SkuCaseModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddOrUpdateSkuCase);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            AddOrUpdateSkuCaseOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void SkuCaseOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? activeTab);

        [NonAction]
        public override System.Web.Mvc.ActionResult SkuCase(int? activeTab)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuCase);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "activeTab", activeTab);
            SkuCaseOverride(callInfo, activeTab);
            return callInfo;
        }

        [NonAction]
        partial void GetSkuCaseEditorOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string skuCaseId);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetSkuCaseEditor(string skuCaseId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetSkuCaseEditor);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "skuCaseId", skuCaseId);
            GetSkuCaseEditorOverride(callInfo, skuCaseId);
            return callInfo;
        }

        [NonAction]
        partial void SkuCaseAddPartialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult SkuCaseAddPartial()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuCaseAddPartial);
            SkuCaseAddPartialOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CustSkuCasePreferenceEditorOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string customerId);

        [NonAction]
        public override System.Web.Mvc.ActionResult CustSkuCasePreferenceEditor(string customerId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustSkuCasePreferenceEditor);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "customerId", customerId);
            CustSkuCasePreferenceEditorOverride(callInfo, customerId);
            return callInfo;
        }

        [NonAction]
        partial void DelPackingRuleOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string style, string caseId, int? activeTab);

        [NonAction]
        public override System.Web.Mvc.ActionResult DelPackingRule(string style, string caseId, int? activeTab)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DelPackingRule);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "style", style);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "caseId", caseId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "activeTab", activeTab);
            DelPackingRuleOverride(callInfo, style, caseId, activeTab);
            return callInfo;
        }

        [NonAction]
        partial void PackingRuleAddViewOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string style, string caseId, bool? ignoreFlag);

        [NonAction]
        public override System.Web.Mvc.ActionResult PackingRuleAddView(string style, string caseId, bool? ignoreFlag)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PackingRuleAddView);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "style", style);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "caseId", caseId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ignoreFlag", ignoreFlag);
            PackingRuleAddViewOverride(callInfo, style, caseId, ignoreFlag);
            return callInfo;
        }

        [NonAction]
        partial void AddPackingRuleOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.ViewModels.Config.PackingRulesModel model, int? activeTab);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddPackingRule(DcmsMobile.PickWaves.ViewModels.Config.PackingRulesModel model, int? activeTab)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddPackingRule);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "activeTab", activeTab);
            AddPackingRuleOverride(callInfo, model, activeTab);
            return callInfo;
        }

        [NonAction]
        partial void ConstraintOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? selectedTab);

        [NonAction]
        public override System.Web.Mvc.ActionResult Constraint(int? selectedTab)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Constraint);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "selectedTab", selectedTab);
            ConstraintOverride(callInfo, selectedTab);
            return callInfo;
        }

        [NonAction]
        partial void CustomerConstraintEditViewOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string customerId);

        [NonAction]
        public override System.Web.Mvc.ActionResult CustomerConstraintEditView(string customerId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustomerConstraintEditView);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "customerId", customerId);
            CustomerConstraintEditViewOverride(callInfo, customerId);
            return callInfo;
        }

        [NonAction]
        partial void CustomerConstraintAddViewOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult CustomerConstraintAddView()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustomerConstraintAddView);
            CustomerConstraintAddViewOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void UpdateCustomerConstraintsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string customerId, DcmsMobile.PickWaves.ViewModels.Config.CustomerConstraintEditorModel constraints, int? activeTab);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateCustomerConstraints(string customerId, DcmsMobile.PickWaves.ViewModels.Config.CustomerConstraintEditorModel constraints, int? activeTab)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateCustomerConstraints);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "customerId", customerId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "constraints", constraints);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "activeTab", activeTab);
            UpdateCustomerConstraintsOverride(callInfo, customerId, constraints, activeTab);
            return callInfo;
        }

        [NonAction]
        partial void CustomerAutocompleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string term);

        [NonAction]
        public override System.Web.Mvc.ActionResult CustomerAutocomplete(string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustomerAutocomplete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            CustomerAutocompleteOverride(callInfo, term);
            return callInfo;
        }

        [NonAction]
        partial void StyleAutoCompleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string term);

        [NonAction]
        public override System.Web.Mvc.ActionResult StyleAutoComplete(string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.StyleAutoComplete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            StyleAutoCompleteOverride(callInfo, term);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
