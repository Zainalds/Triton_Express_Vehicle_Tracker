using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Application.MVC.Models
{
    public class WaybillViewModel
    {
        public int WaybillId { get; set; }

        public string Waybill_Total_weight { get; set; }

        public string Waybil_Total_Parcels_Allocated { get; set; }

        public int Vehicle_Registration_Number { get; set; }

        public string Vehicle_Number_Plate { get; set; }

        [ForeignKey("Vehicle_Registration_Number")]
        public VehicleViewModel Vehicle { get; set; }

    }
}