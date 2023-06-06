﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class TblBu
    {
        public TblBu()
        {
            TblDrivers = new HashSet<TblDriver>();
        }

        public string BusId { get; set; }
        public string NumberPlate { get; set; }
        public string BusType { get; set; }
        public int? SeatQuantity { get; set; }
        public int? EngineOuput { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? PeriodicMaintenance { get; set; }
        public string RoutesId { get; set; }

        public virtual TblBusRoute Routes { get; set; }
        public virtual ICollection<TblDriver> TblDrivers { get; set; }
    }
}
