using Microsoft.AspNetCore.Identity;
using SIRH_DataBase;
using SIRH_DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIRH
{
    public class Seed
    {
        public static async Task SeedData(DatabaseContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //string[] roles = { Profiles.Admin, Profiles.Reader };
            //foreach (var role in roles)
            //{
            //    var roleExist = await roleManager.RoleExistsAsync(role);
            //    if (!roleExist)
            //    {
            //        //create the roles and seed them to the database: Question 1
            //        await roleManager.CreateAsync(new IdentityRole(role));
            //    }
            //}
        }
    }
}
