using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SeyrekTur.Business.Abstract;
using SeyrekTur.Data.Concrete;
using SeyrekTur.WebUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SeyrekTur.WebUI.Controllers
{
    [Authorize]
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
            }) ;
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


        public IActionResult ExportDinamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Bilet ID";
                worksheet.Cell(1, 2).Value = "Ad Soyad";
                worksheet.Cell(1, 3).Value = "Mail";

                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheet.Cell(BlogRowCount, 2).Value = item.Name + item.Surname;
                    worksheet.Cell(BlogRowCount, 3).Value = item.Mail;
                    BlogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YolcuListesi.xlsx");
                }
            }
        }

        public List<TicketModel> GetBlogList()
        {
            List<TicketModel> bm = new List<TicketModel>();
            using (var c=new TurContext())
            {
                bm = c.Tickets.Select(x => new TicketModel()
                {
                    ID = x.TicketId,
                    Name = x.Name,
                    Surname = x.Surname,
                    Mail = x.Mail
                }).ToList();
            }
            return bm;
        }
    }
}
