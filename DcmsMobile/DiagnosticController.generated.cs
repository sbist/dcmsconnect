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
namespace DcmsMobile.MainArea.Diagnostic
{
    public partial class DiagnosticController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DiagnosticController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected DiagnosticController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Email()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Email);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SendEmail()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SendEmail);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DiagnosticController Actions { get { return MVC_DcmsMobile.Diagnostic; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Diagnostic";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Diagnostic";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Email = "Email";
            public readonly string SendEmail = "SendEmail";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Email = "Email";
            public const string SendEmail = "SendEmail";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string emulateMobile = "emulateMobile";
        }
        static readonly ActionParamsClass_Email s_params_Email = new ActionParamsClass_Email();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Email EmailParams { get { return s_params_Email; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Email
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_SendEmail s_params_SendEmail = new ActionParamsClass_SendEmail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SendEmail SendEmailParams { get { return s_params_SendEmail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SendEmail
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
                public readonly string Email = "Email";
                public readonly string Index = "Index";
            }
            public readonly string Email = "~/MainArea/Diagnostic/Email.cshtml";
            public readonly string Index = "~/MainArea/Diagnostic/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_DiagnosticController : DcmsMobile.MainArea.Diagnostic.DiagnosticController
    {
        public T4MVC_DiagnosticController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, bool? emulateMobile);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(bool? emulateMobile)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emulateMobile", emulateMobile);
            IndexOverride(callInfo, emulateMobile);
            return callInfo;
        }

        [NonAction]
        partial void EmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.MainArea.Diagnostic.DiagnosticModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult Email(DcmsMobile.MainArea.Diagnostic.DiagnosticModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Email);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EmailOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void SendEmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.MainArea.Diagnostic.DiagnosticEmailModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult SendEmail(DcmsMobile.MainArea.Diagnostic.DiagnosticEmailModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SendEmail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SendEmailOverride(callInfo, model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
