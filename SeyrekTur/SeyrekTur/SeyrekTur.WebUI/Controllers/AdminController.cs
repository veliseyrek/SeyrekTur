using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeyrekTur.Business.Abstract;
using SeyrekTur.WebUI.Identity;
using SeyrekTur.WebUI.Models;
using System.Threading.Tasks;

namespace SeyrekTur.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        
        private UserManager<User> _userManager;
        private ITicketService _ticketService;
        public AdminController(ITicketService ticketService, UserManager<User> userManager)
        {
            this._userManager = userManager;
            this._ticketService = ticketService;
        }
        public IActionResult Index()
        {
            return View(new TicketRoute()
            {
                Tickets = _ticketService.GetAll()         
            });           
        }
        
        public async Task<IActionResult> SettingProfile()
        {
            //var user = _userManager.(id)
            var entity = await _userManager.GetUserAsync(User);
            var user = new RegisterModel()
            {             
                    FirstName=entity.FirstName,
                    LastName=entity.LastName,
                    Email=entity.Email,
                    UserName = entity.UserName              
            };
            return View(user);
        }

        [HttpPost]
        public IActionResult SettingProfile(RegisterModel model)
        {
            return View();
        }

        public  IActionResult Contact()
        {
            //var entity = await _userManager.GetUserAsync(User);
            //var user = new RegisterModel()
            //{
            //    FirstName = entity.FirstName,
            //    LastName = entity.LastName,
            //    Email = entity.Email,
            //    UserName = entity.UserName               
            //};

            //return View(user);

            return View(_userManager.Users);
        }
    }
}
