using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SeyrekTur.Business.Abstract;
using SeyrekTur.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SeyrekTur.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICityService _cityService;
        private IRouteService _routeService;

        public HomeController(ICityService cityService, IRouteService routeService)
        {
            this._cityService = cityService;
            this._routeService = routeService;
        }

        public IActionResult Index(string from , string to)
        {
            if (from==null||to==null||from==to)
            {
                var cityModel = new TicketRoute()
                {
                    Cities = _cityService.GetAll(),
                    Routes = null
                };

                ViewBag.Sehirler = new SelectList(cityModel.Cities, "CityId", "CityName");
                return View(cityModel);
            }
            else
            {
                var cityModel = new TicketRoute()
                {
                    Cities = _cityService.GetAll(),
                    Routes = _routeService.GetTravel(from, to)
                };
                TempData["from"] = _routeService.GetFrom(from);
                TempData["to"] = _routeService.GetTo(to);
                ViewBag.Sehirler = new SelectList(cityModel.Cities, "CityId", "CityName");
                return View(cityModel);
            }
           
        }

        public IActionResult Iletisim()
        {
            ViewData["title"] = "İletişim - ";
            return View();
        }
        public IActionResult Sehir()
        {
            var values = _cityService.GetAll();
            return View(values);
        }


    }
}
