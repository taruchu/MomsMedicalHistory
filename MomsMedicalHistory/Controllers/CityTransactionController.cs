using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MomsMedicalHistory.Models;
 

namespace MomsMedicalHistory.Controllers
{
     
    public class CityTransactionController : Controller
    {
        public ActionResult CityList()
        {
            IEnumerable<city> model = Medical_Machine_Routeens
                                       .Read_city();
            return View("CityList", model);
        }

        public ActionResult CityListRefresh()
        {
            IEnumerable<city> model = Medical_Machine_Routeens
                                        .Read_city();
            return PartialView("CityListPartial", model);
        }
        public ActionResult ViewCity(int id)
        {
            city model =  Medical_Machine_Routeens
                            .Read_city(id)
                            .FirstOrDefault<city>();
            return PartialView("City", model);
        }

        public ActionResult ExecuteCityTransaction(city model)
        {
            if (model.city_ID > 0) 
                Medical_Machine_Routeens.Update_city(model);       
            else 
                Medical_Machine_Routeens.Create_city(model); 
                 
            return RedirectToAction("ViewCity", new { id = model.city_ID });
        }
 
    }
}