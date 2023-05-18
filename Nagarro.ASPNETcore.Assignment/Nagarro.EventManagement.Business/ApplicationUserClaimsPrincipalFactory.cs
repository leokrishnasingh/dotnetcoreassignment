using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Nagarro.EventManagement.Shared;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Nagarro.EventManagement.Business
{

    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
        {
            public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager,
                RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> options)
                : base(userManager, roleManager, options)
            {
            }



            protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
            {
                var identity = await base.GenerateClaimsAsync(user);
                identity.AddClaim(new Claim("UserFullName", user.FullName ?? "NoUser"));
                return identity;
            }
        }
}
