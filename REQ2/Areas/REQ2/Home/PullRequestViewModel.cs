﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DcmsMobile.REQ2.Areas.REQ2.Home
{
    public class PullRequestSkuModel
    {
        public PullRequestSkuModel()
        {
   
        }

        internal PullRequestSkuModel(RequestSku entity)
        {
            // Source SKU
            this.Style = entity.SourceSku.Style;
            this.Color = entity.SourceSku.Color;
            this.Dimension = entity.SourceSku.Dimension;
            this.SkuSize = entity.SourceSku.SkuSize;

       
                this.TargetStyle = entity.SourceSku.Style;
                this.TargetColor = entity.SourceSku.Color;
                this.TargetDimension = entity.SourceSku.Dimension;
                this.TargetSkuSize = entity.SourceSku.SkuSize;

            
            

        }

        [Display(Name = "Style")]
        public string Style { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "Dim")]
        public string Dimension { get; set; }

        [Display(Name = "Size")]
        public string SkuSize { get; set; }

        public string UpcCode { get; set; }

        [Display(Name = "SKU")]
        public string DisplaySku
        {
            get
            {
                return  string.Format(Style + "," + Color + "," + Dimension + "," + SkuSize) ;
            }
        }

        [Display(Name = "Target Style")]
        public string TargetStyle { get; set; }

        [Display(Name = "Target Color")]
        public string TargetColor { get; set; }

        [Display(Name = "Terget Dim")]
        public string TargetDimension { get; set; }

        [Display(Name = "Target Size")]
        public string TargetSkuSize { get; set; }

        public string TargetUpcCode { get; set; }

        [Display(Name = "Target SKU")]
        public string DisplayTargetSku
        {
            get
            {
                return this.Style != null ? string.Format(TargetStyle + "," + TargetColor + "," + TargetDimension + "," + TargetSkuSize) : string.Empty;
            }
        }

    }

    public class AssignedCartonListModel
    {

        public AssignedCartonListModel()
        {
            
        }
        internal AssignedCartonListModel(AssignedCarton entity)
        {
            this.Sku = new SkuModel
            {
                Style = entity.Sku.Style,
                Color = entity.Sku.Color,
                Dimension = entity.Sku.Dimension,
                SkuSize = entity.Sku.SkuSize
            };
           
            this.TotalCartons = entity.TotalCartons;
            this.TotalPieces = entity.TotalPieces;
            this.PulledCartons = entity.PulledCartons;
            this.PulledPieces = entity.PulledPieces;
        }

        public SkuModel Sku { get; set; }

        public int TotalCartons { get; set; }

        public int PulledCartons { get; set; }

        public int TotalPieces { get; set; }

        public int PulledPieces { get; set; }


    }

    public class PullRequestViewModel
    {
        public PullRequestViewModel()
        {

        }

        internal PullRequestViewModel(PullRequest entity)
        {
            this.CtnResvId = entity.CtnResvId;
            this.SourceAreaShortName = entity.SourceAreaShortName;
            this.DestinationAreaShortName = entity.DestinationAreaShortName;
            this.IsConversionRequest = entity.IsConversionRequest;
            this.Priority = entity.Priority;
            this.SaleTypeId = entity.SaleTypeId;
            this.AllowOverPulling = entity.AllowOverPulling;
            this.PackagingPreferance = entity.PackagingPreferance;
            this.Remarks = entity.Remarks;
            this.RequestedBy = entity.RequestedBy;
            this.DateCreated = entity.DateCreated;
            this.QuantityRequested = entity.QuantityRequested;
            this.SourceQuality = entity.SourceQuality;
            this.TargetQuality = entity.TargetQuality;
            this.SourceVwhId = entity.TargetVwhId;
            this.AssignedPieces = entity.AssignedPieces;
            this.BuildingId = entity.BuildingId;
            this.PriceSeasonCode = entity.PriceSeasonCode;
            this.SewingPlantCode = entity.SewingPlantCode;
        }


        public string CtnResvId { get; set; }

        public string SourceAreaShortName { get; set; }

        public string DestinationAreaShortName { get; set; }

        public bool IsConversionRequest { get; set; }

        public string Priority { get; set; }
        public string SaleTypeId { get; set; }

        public string AllowOverPulling { get; set; }

        public string PackagingPreferance { get; set; }

        public string Remarks { get; set; }

        public string RequestedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public int QuantityRequested { get; set; }

        public string SourceVwhId { get; set; }

        public string TargetVwhId { get; set; }

        public string SourceQuality { get; set; }

        public string TargetQuality { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int AssignedPieces { get; set; }

        public string BuildingId { get; set; }

        public string PriceSeasonCode { get; set; }

        public string SewingPlantCode { get; set; }

        public IList<PullRequestSkuModel> SkuList { get; set; }

        public IList<AssignedCartonListModel> CartonList { get; set; }


    }
}

