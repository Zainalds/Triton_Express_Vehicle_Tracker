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
                HttpResponseMessage response = Globalvariables.client.GetAsync("api/Waybills/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<WaybillViewModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(WaybillViewModel emp)
        {                
                HttpResponseMessage response = Globalvariables.client.PostAsJsonAsync("api/Waybills", emp).Result;
                TempData["SuccessMessage"] = "Saved Successfully";

            return RedirectToAction("Index");
        }
    }
}