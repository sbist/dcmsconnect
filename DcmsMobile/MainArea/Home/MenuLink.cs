﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DcmsMobile.MainArea.Home
{
    public class MenuLink
    {
        public string RouteName { get; set; }

        public string ShortCut { get; set; }

        public string Name { get; set; }

        public bool? Mobile { get; set; }

        public string Description { get; set; }

        public int? Order { get; set; }

        public string CategoryId { get; set; }

        public bool? Visible { get; set; }
    }
}
