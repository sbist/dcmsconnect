﻿using DcmsMobile.PickWaves.Repository;
namespace DcmsMobile.PickWaves.Areas.PickWaves.CreateWave
{
    internal class CreateWaveArea : InventoryArea
    {
        /// <summary>
        /// Number of ordered SKU which can be found in this area
        /// </summary>
        public int? CountSku { get; set; }

        public int? CountOrderedSku { get; set; }

    }
}