using Microsoft.AspNetCore.Mvc;
using SeyrekTur.Business.Abstract;
using SeyrekTur.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeyrekTur.WebUI.Controllers
{
    public class UserController : Controller
    {
        private ITicketService _ticketService;
        public UserController(ITicketService ticketService)
        {
            this._ticketService = ticketService;
        }


        public IActionResult AdminList()
        {
            return View(new TicketRoute()
            {
                Tickets = _ticketService.GetAll()
            });
        }

        public IActionResult IptalBilet(int biletId)
        {
            var bilet = _ticketService.GetById(biletId);
            if (bilet != null)
            {
                _ticketService.Delete(bilet);
            }
            return RedirectToAction("AdminList");
        }
    }
}
