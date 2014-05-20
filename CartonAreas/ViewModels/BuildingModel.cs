﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DcmsMobile.CartonAreas.ViewModels
{
    public class BuildingModel
    {
        public string BuildingId { get; set; }

        public string Description { get; set; }

        public DateTime? InsertDate { get; set; }

        public string InsertedBy { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address4 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public int? CountArea { get; set; }

        public int? CountNumberedArea { get; set; }

        [DisplayFormat(DataFormatString="{0:N0}")]
        public int? CountLocation { get; set; }

        public string Address3 { get; set; }

        public int? ReceivingPalletLimit { get; set; }
    }
}