using Microsoft.AspNetCore.Identity;
using Nagarro.EventManagement.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.EntityDataModel.DataAccessComponents
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(UserDTO userDTO);

        Task<SignInResult> IsValidUser(LoginDTO loginDTO);

        Task SignOutUser();

        Task<string> GetUserName(string email);
    }
}
