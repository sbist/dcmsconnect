﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DcmsMobile.Receiving.ViewModels.Home
{
    public class ReceivingViewModel : ViewModelBase
    {
        public const string SCAN_NEWPALLET = "PNEW";

        public ReceivingViewModel()
        {
            this.Pallets = new PalletViewModel[] { };
            this.ScanModel = new ScanViewModel();

            // To prevent the Required Error
            //this.ProDate = DateTime.MinValue;
            //this.ProNumber = string.Empty;
            //this.ExpectedCartons = 1;
        }

        public int? PalletLimit { get; set; }

        public string PriceSeasonCode { get; set; }

        public DateTime? ProDate { get; set; }

        public string ProNumber{ get; set; }

        public int? ProcessId {get; set; }

        public string SpotCheckAreaId { get; set; }

        public string OperatorName { get; set; }

        public string ReceivingAreaId { get; set; }

        public IList<PalletViewModel> Pallets { get; set; }

        //This property keep the list of all NonPalletizeCartons.
        private IEnumerable<CartonNotOnPalletModel> _nonPalletizeCarton;
        public IEnumerable<CartonNotOnPalletModel> NonPalletizeCartonList
        {
            get { return _nonPalletizeCarton ?? (_nonPalletizeCarton = Enumerable.Empty<CartonNotOnPalletModel>().ToList()); }
            set
            {
                _nonPalletizeCarton = value;
            }
        }

        //#region Printing 

        //[Obsolete]
        //[Display(Name = "Printer")]
        //public string PrinterId { get; set; }

        //[Obsolete]
        //public IEnumerable<SelectListItem>PrinterList { get; set; }

        //#endregion


        /// <summary>
        /// Becomes true if the logged in user does not match the user who created the process
        /// </summary>
        /// <remarks>
        /// It never becomes true if the user is not logged in
        /// </remarks>
        public bool UserMismatch { get; set; }

        [Obsolete]
        public ScanViewModel ScanModel { get; set; }

        public string CarrierId{get;set;}

        /// <summary>
        /// Url of Report 40.103: Summary of the Shipments as well as cartons received.
        /// </summary>
        public string ProcessDetailUrl
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["DcmsLiveBaseUrl"] + "Reports/Category_040/R40_103.aspx";
            }
        }

        public int? ExpectedCartons { get; set; }

        public int CartonCount { get; set; }

        public int percentReceivedCartons
        {
            get
            {
                if ((this.ExpectedCartons ?? 0) <= 0)
                {
                    return 0;
                }
            return (int)Math.Round(this.CartonCount * 100.0 / this.ExpectedCartons.Value);

            }
        }

    }

    /// <summary>
    /// This information is posted back at each scan
    /// </summary>
    public class ScanViewModel
    {
        [Required(ErrorMessage = "Process ID is required")]
        public int? ProcessId { get; set; }

        [Required(ErrorMessage = "Must scan something")]
        [Display(Name = "Scan Carton or Pallet")]
        public string ScanText { get; set; }

        /// <summary>
        /// Currently active pallet
        /// </summary>
        public string PalletId { get; set; }

        /// <summary>
        /// Disposition of the currently active pallet
        /// </summary>
        public string PalletDispos { get; set; }
    }
}



//$Id$