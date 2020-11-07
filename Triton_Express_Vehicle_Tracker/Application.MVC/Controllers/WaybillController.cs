using Application.MVC.Models;
using Application.MVC.Webservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Application.MVC.Controllers
{
    public class WaybillController : Controller
    {
        // GET: Waybill
        public ActionResult Index()
        {
            IEnumerable<WaybillViewModel> list;
            HttpResponseMessage response = Globalvariables.client.GetAsync("api/Waybills").Result;
            list = response.Content.ReadAsAsync<IEnumerable<WaybillViewModel>>().Result;
            return View(list);
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                Waybillddl lc = new Waybillddl();
                ViewBag.listAuthers = new SelectList(lc.GetVehicleId(), "Vehicle_Registration_Number", "Vehicle_Number_Plate");
                return View(new WaybillViewModel());
            }
            else
            {
                Waybillddl lc = new Waybillddl();
                var numberPlate = (from x in lc.GetVehicleId()
                                   where x.Vehicle_Registration_Number == id
                                   select x.Vehicle_Number_Plate).Single();

                ViewBag.n = numberPlate.ToString();
                return View();
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(WaybillViewModel emp)
        {

            if(emp.Vehicle_Number_Plate == null)
            {
                HttpResponseMessage response = Globalvariables.client.PostAsJsonAsync("api/Waybills", emp).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                Waybillddl lc = new Waybillddl();

                int Vehicle_Registration_Number = (from x in lc.GetVehicleId()
                                                   where x.Vehicle_Number_Plate == emp.Vehicle_Number_Plate
                                                   select x.Vehicle_Registration_Number).Single();

                WaybillViewModel obj = new WaybillViewModel();

                obj.WaybillId = emp.WaybillId;
                obj.Waybill_Total_weight = emp.Waybill_Total_weight;
                obj.Waybil_Total_Parcels_Allocated = emp.Waybil_Total_Parcels_Allocated;
                obj.Vehicle_Registration_Number = Vehicle_Registration_Number;
                obj.Vehicle_Number_Plate = emp.Vehicle_Number_Plate;

                HttpResponseMessage response = Globalvariables.client.PostAsJsonAsync("api/Waybills", obj).Result;
                TempData["SuccessMessage"] = "Saved Successfully";

                return RedirectToAction("Index");
            }
        }
    }
}