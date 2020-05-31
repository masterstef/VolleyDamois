using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Data
{
    public static class DataInitializer
    {
        public static async Task SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRole(roleManager);
            await SeedUser(userManager);
        }
        private static async Task SeedRole(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin")) {
                IdentityRole user = new IdentityRole() {Name = "Admin"};
                var result = roleManager.CreateAsync(user).Result;
            }
        }

        private static async Task SeedUser(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("volleyDamois@test.com").Result == null)
            {
                IdentityUser user = new IdentityUser()
                {
                    Email = "volleyDamois@test.com",
                    UserName = "volleyDamois@test.com"
                };
                var result = await userManager.CreateAsync(user, "Test123/");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }

            }
        }
    }
}