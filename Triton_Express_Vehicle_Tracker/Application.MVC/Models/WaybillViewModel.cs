using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Application.MVC.Models
{
    public class WaybillViewModel
    {
        public int WaybillId { get; set; }

        [Required]
        public string Waybill_Total_weight { get; set; }
        [Required]

        public string Waybil_Total_Parcels_Allocated { get; set; }
        [Required]

        public int Vehicle_Registration_Number { get; set; }
        [Required]

        public string Vehicle_Number_Plate { get; set; }

        [ForeignKey("Vehicle_Registration_Number")]
        public VehicleViewModel Vehicle { get; set; }

    }
}