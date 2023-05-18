using Microsoft.AspNetCore.Mvc;
using Nagarro.EventManagement.Business;
using Nagarro.EventManagement.EntityDataModel;
using Nagarro.EventManagement.EntityDataModel.DataAccessComponents;
using Nagarro.EventManagement.UI.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventRepository _eventRepository;
        private readonly IAccountRepository _accountRepository;
        public HomeController(IEventRepository eventRepository,IAccountRepository accountRepository)
        {
            _eventRepository = eventRepository;
            _accountRepository = accountRepository;
        }

        /// <summary>
        /// Homepage of our Project
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            string str = "";
            if (User.Identity.IsAuthenticated)
            {
                str = await _accountRepository.GetUserName(User.Identity.Name);

            }
            ViewBag.UserName = str;
            
            var result = _eventRepository.GetAllEvents();
            return View(result);
        }

        
        /// <summary>
        /// template Simple Privacy Page
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// template action for error handling
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
