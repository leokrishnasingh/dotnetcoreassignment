using Microsoft.AspNetCore.Mvc;
using Nagarro.EventManagement.Business;
using Nagarro.EventManagement.EntityDataModel;
using Nagarro.EventManagement.EntityDataModel.DataAccessComponents;
using Nagarro.EventManagement.Shared;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        /// <summary>
        /// creating a view on browser for signup
        /// </summary>
        /// <returns></returns>
        public IActionResult SignUp()
        {
            return View();
        }

        /// <summary>
        /// Posting a signup data in UserManager
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SignUp(UserDTO userDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountRepository.CreateUserAsync(userDTO);
                if (!result.Succeeded)
                {
                    foreach(var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                    return View();
                }
            }
            ModelState.Clear();

            return RedirectToAction("Login","Account");
        }

        /// <summary>
        /// View of Login pAge
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// checking wheather thge credentials is correct or not
        /// </summary>
        /// <param name="loginDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountRepository.IsValidUser(loginDTO);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Credentials");
                }

            }
            return View();
        }

        /// <summary>
        /// for the logout functionality on the web page
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> LogOut()
        {
            await _accountRepository.SignOutUser();
            return RedirectToAction("Index","Home");
        }
    }
}
