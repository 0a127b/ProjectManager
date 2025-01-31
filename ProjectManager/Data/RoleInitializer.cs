using Microsoft.AspNetCore.Identity;
using ProjectManager.Models;
using System.Threading.Tasks;

namespace ProjectManager.Data
{
    public class RoleInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleInitializer(RoleManager<IdentityRole> roleManager,
                               UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task SeedRolesAsync()
        {
            // Tworzenie ról, jeśli nie istnieją
            string[] roleNames = { "Admin", "User" };
            foreach (var roleName in roleNames)
            {
                if (!await _roleManager.RoleExistsAsync(roleName))
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Tworzenie konta Administratora
            var adminEmail = "admin@projectmanager.local";
            var adminUser = await _userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    DisplayName = "Administrator",
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(adminUser, "Admin123!");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(adminUser, "Admin");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        System.Console.WriteLine($"Error creating admin user: {error.Description}");
                    }
                }
            }

            // Tworzenie konta Zwykłego Użytkownika
            var userEmail = "user@example.com";
            var regularUser = await _userManager.FindByEmailAsync(userEmail);
            if (regularUser == null)
            {
                regularUser = new ApplicationUser
                {
                    UserName = userEmail,
                    Email = userEmail,
                    DisplayName = "Regular User",
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(regularUser, "User123!");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(regularUser, "User");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        System.Console.WriteLine($"Error creating regular user: {error.Description}");
                    }
                }
            }
        }
    }
}