//using System;
//using System.Threading.Tasks;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using ImagineIf.Models;

//private async Task CreateRoles(IServiceProvider serviceProvider)
//{
//    var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//    var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
//    string[] roleNames = { "Admin", "Moderator", "Member" };
//    IdentityResult roleResult;

//    foreach (var roleName in roleNames)
//    {
//        //creating the roles and seeding them into the database
//        var roleExist = await RoleManager.RoleExistsAsync(roleName);
//        if(!roleExist)
//        {
//            roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
//        }
//    }

//    //creating a superuser who could maintain the webapp
//    var poweruser = new ApplicationUser
//    {
//        UserName = Configuration.GetSection("UserSettings")["UserEmail"],
//        Email = Configuration.GetSection("UserSettings")["UserEmail"]
//    };

//    string UserPassword = Configuration.GetSection("UserSettings")["UserPassword"];
//    var _user = await UserManager.FindByEmailAsync(Configuration.GetSection("UserSettings")["UserEmail"]);

//    if(_user == null)
//    {
//        var createPowerUser = await UserManager.CreateAsync(poweruser, UserPassword);
//        if(createPowerUser.Succeeded)
//        {
//            //here we tie the new user to the admin role
//            await UserManager.AddToRoleAsync(poweruser, "Admin");
//        }
//    }
//}