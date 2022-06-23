using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeyrekTur.Business.Abstract;
using SeyrekTur.Entity;
using SeyrekTur.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeyrekTur.WebUI.Controllers
{
    public class TravelController : Controller
    {
        private IRouteService _routeService;
        private ITicketService _ticketService;

        public TravelController(IRouteService routeService, ITicketService ticketService)
        {
            this._routeService = routeService;
            this._ticketService = ticketService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Route route = _routeService.GetRouteDetails(id);
            int routeSeatNumber = _ticketService.GetCountBySeat(id);
            List<int> dolukoltuklar = _ticketService.GetSeat(id);
            var seats = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            foreach (var item in dolukoltuklar)
            {
                seats.Remove(item);
            }

            ViewBag.Sayi = routeSeatNumber;
            ViewBag.Koltuklar = new SelectList(seats);

            if (route == null)
            {
                return NotFound();
            }
            else
            {
                //var sehirModel = new BiletGuzergah()
                //{

                //    YeniGuzergah = guzergah
                //};
                return View(route);
            }
        }

        [HttpPost]
        public IActionResult Details(int routeId, double price, string from, string to, int seatno, string email, string name, string surname)
        {
            var entity = new Ticket()
            {
                Name = name,
                Surname = surname,
                Mail = email,
                From = from,
                To = to,
                SeatNo = seatno,
                Price = price,
                RouteId = routeId
            };
            _ticketService.Create(entity);
            return RedirectToAction("Basarili");
        }



        public IActionResult Basarili()
        {
            Ticket yeni = _ticketService.GetLastEntry();
            int guzergahid = _ticketService.GetId();
            string guzergahsaat = _ticketService.GetHour(guzergahid);
            string guzergahtarih = _ticketService.GetDate(guzergahid);

            var BiletGuzergahh = new TicketRoute()
            {
                date = guzergahtarih,
                hour = guzergahsaat,
                ticket = yeni
            };
            return View(BiletGuzergahh);
        }
    }
}
