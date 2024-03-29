﻿using data_access.data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace SteamProjectG2.Helpers
{
    public static class Roles
    {
        public const string ADMIN = "admin";
        public const string USER = "user";
    }

    public static class Seeder
    {
        public static async Task SeedRoles(this IServiceProvider app)
        {
            var roleManager = app.GetRequiredService<RoleManager<IdentityRole>>();

            var roles = typeof(Roles).GetFields(
                BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Select(x => (string)x.GetValue(null)!);

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        public static async Task SeedAdmin(this IServiceProvider app)
        {
            var userManager = app.GetRequiredService<UserManager<User>>();

            const string USERNAME = "myadmin@myadmin.com";
            const string PASSWORD = "Admin1@";
            const string AVATAR = "https://cdn3.f-cdn.com/contestentries/1211056/27637491/5a39bea42397c_thumb900.jpg";
            const string SUMMARY = "Doesn't exist";

            var existingUser = await userManager.FindByNameAsync(USERNAME);

            if (existingUser == null)
            {
                var user = new User
                {
                    UserName = USERNAME,
                    Email = USERNAME,
                    AvatarUrl = AVATAR,
                    Summary = SUMMARY,
                    CountryId = 1
                };

                var result = await userManager.CreateAsync(user, PASSWORD);

                if (result.Succeeded)
                    await userManager.AddToRoleAsync(user, Roles.ADMIN);
            }
        }
    }
}
