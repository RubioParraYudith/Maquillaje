﻿using Maquillaje.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maquillaje.Web.Clase
{
    public class utilities
    {
        readonly static ApplicationDbContext db = new ApplicationDbContext();
        public static void CheckRoles(string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            if (!roleManager.RoleExists(roleName))
            {
                roleManager.Create(new IdentityRole(roleName));
            }
        }
        internal static void CheckSuperUser()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var userAsp = userManager.FindByName("admin@gmail.com");

            if (userAsp == null)
            {
                CreateUserASP("admin@gmail.com", "admin1234", "Admin");
            }
        }

        internal static void CheckClientDefault()
        {
            var clientdb = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var userclient = clientdb.FindByName("cliente@gmail.com");
            if (userclient == null)
            {
                CreateUserASP("cliente@gmail.com", "cliente123", "Client");
                userclient = clientdb.FindByName("cliente@gmail.com");
                var client = new Client
                {
                    UserId = userclient.Id,
                };

                db.Clients.Add(client);
                db.SaveChanges();
            }


        }
        public static void CreateUserASP(string email, string password, string rol)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var userASP = new ApplicationUser()
            {
                UserName = email,
                Email = email,
            };

            userManager.Create(userASP, password);
            userManager.AddToRole(userASP.Id, rol);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}