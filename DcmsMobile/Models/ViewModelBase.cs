﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DcmsMobile.Models
{
    /// <summary>
    /// A link to utility functions such as logn, diagnostics etc.
    /// </summary>
    public class UtilityLink
    {
        public string Url { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }
    }

    /// <summary>
    /// Used as model by layout views.
    /// </summary>
    public class ViewModelBase
    {
        private IList<UtilityLink> _masterMenuItems;

        public string HomeUrl { get; set; }

        /// <summary>
        /// Contains information about login/logoff/changepassword/diagnostic links
        /// </summary>
        public IList<UtilityLink> MasterMenuItems
        {
            get { return _masterMenuItems; }
        }

        /// <summary>
        /// Populates the master menu items depending on whether the user is logged in or not
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="url"></param>
        public virtual void Init(ControllerContext ctx, UrlHelper url)
        {
            var list = new List<UtilityLink>();

            // Home
            var str = url.Action(MVC_DcmsMobile.Home.Index());
            if (string.Compare(str, ctx.HttpContext.Request.Url.AbsolutePath, true) == 0)
            {
                // Home Url not needed when we are on the home page
                HomeUrl = "#";
            }
            else
            {
                HomeUrl = str;
            }

            if (ctx.HttpContext.User.Identity.IsAuthenticated)
            {
                // Logoff
                //LogoffUrl = url.Action(MVC_DcmsMobile.Logon.Logoff());
                list.Add(new UtilityLink
                {
                    Name = string.Format("Log off {0}", ctx.HttpContext.User.Identity.Name),
                    Url = url.Action(MVC_DcmsMobile.Logon.Logoff())
                });
                //PasswordUrl = url.Action(MVC_DcmsMobile.Logon.GetNewPassword());
                list.Add(new UtilityLink
                {
                    Name = "Change Password",
                    Url = url.Action(MVC_DcmsMobile.Logon.GetNewPassword())
                });
            }
            else
            {
                // Logon
                str = url.Action(MVC_DcmsMobile.Logon.Index());
                if (string.Compare(str, ctx.HttpContext.Request.Url.AbsolutePath, true) != 0)
                {

                    list.Add(new UtilityLink
                    {
                        Name = "Login",
                        Url = str
                    });
                }
            }
            str = url.Action(MVC_DcmsMobile.Diagnostic.Index());
            if (string.Compare(str, ctx.HttpContext.Request.Url.AbsolutePath, true) != 0)
            {
                list.Add(new UtilityLink
                {
                    Name = "Diagnostic",
                    Url = str
                });
            }
            _masterMenuItems = list;
        }
    }
}
