﻿using System.Collections.Generic;
using System;

namespace DcmsMobile.Receiving.Areas.Receiving.Home.Repository
{
    internal class Pallet
    {
        public string PalletId { get; set; }


        public int PalletLimit { get; set; }

        public int ProcessId { get; set; }

        public IList<ReceivedCarton> Cartons { get; set; }
    }
}



//$Id$