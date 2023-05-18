using Microsoft.AspNetCore.Identity;
using Nagarro.EventManagement.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.EntityDataModel.DataAccessComponents
{ 
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Creating a new User in The database{Every email must be unique}
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public async Task<IdentityResult> CreateUserAsync(UserDTO userDTO)
        {

            var u = new ApplicationUser()
            {
                Email = userDTO.Email,
                UserName = userDTO.Email,
                FullName = userDTO.FullName
            };


            var result = await _userManager.CreateAsync(u, userDTO.Password);

            return result;
        }

        /// <summary>
        /// Validating wheather a user email and password is correct or NOt
        /// </summary>
        /// <param name="loginDTO"></param>
        /// <returns></returns>
        public async Task<SignInResult> IsValidUser(LoginDTO loginDTO)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDTO.Email, loginDTO.Password, false, false);

            return result;
        }


        /// <summary>
        /// Signout the user 
        /// </summary>
        /// <returns></returns>
        public async Task SignOutUser()
        {
            await _signInManager.SignOutAsync();
        }

        /// <summary>
        /// Fetching the full name of the signed in User 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<string> GetUserName(string email)
        {
            var user = await _userManager.FindByNameAsync(email);
            return user.FullName;
        }

    }
}
