using fiorello_project.Constants;
using fiorello_project.Models;
using Microsoft.AspNetCore.Identity;

namespace fiorello_project.Helpers
{
    public class DbInitializer
    {


        public async static Task SeedAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {

            foreach (var role in Enum.GetValues(typeof(UserRoles)))
            {
                if (!await roleManager.RoleExistsAsync(role.ToString()))
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = role.ToString(),
                    });

                }

            }

            if ((await userManager.FindByNameAsync("admin")) == null)
            {

                var user = new User
                {
                    Fullname = "admin",
                    UserName = "admin",
                    Email = "admin999@gmail.com"

                };

                var result = await userManager.CreateAsync(user, "Admin12345678*");
                if (!result.Succeeded)
                {

                    foreach (var error in result.Errors)
                    {
                        throw new Exception(error.Description);
                    }
                }

                await userManager.AddToRoleAsync(user, UserRoles.Admin.ToString());
            }

        }
    }


}

