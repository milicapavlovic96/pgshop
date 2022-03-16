using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Milica",
                    Email = "milica@test.com",
                    UserName = "milica@test.com",
                    Address = new Address
                    {
                        FirstName = "Milica",
                        LastName = "Pavlovic",
                        Street = "9 Jugovica 45",
                        City = "Veternik",
                        State = "Srbija",
                        ZipCode = "21203"
                    }
                };

                await userManager.CreateAsync(user, "mica");
            }
        }
    }
}