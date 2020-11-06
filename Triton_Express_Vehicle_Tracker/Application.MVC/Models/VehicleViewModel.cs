using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.MVC.Models
{
    public class VehicleViewModel
    {
        public int Vehicle_Registration_Number { get; set; }

        public string Vehicle_Number_Plate { get; set; }

        public string Vehicle_Make { get; set; }

        public string Vehicle_Model { get; set; }

        public string Branch { get; set; }

        public virtual List<WaybillViewModel> Waybill { get; set; }
    }
}