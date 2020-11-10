﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GamingStore.Data;
using GamingStore.Models;
using GamingStore.ViewModels;
using GamingStore.ViewModels.Errors;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamingStore.Controllers
{
    public class ErrorsController : BaseController
    {
        public ErrorsController(UserManager<Customer> userManager, StoreContext context, RoleManager<IdentityRole> roleManager) : base(userManager, context, roleManager)
        {
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> NotFound()
        {
            var itemNumber = await CountItemsInCart();
            var errorViewModel = new ErrorViewModel
            {
                ItemsInCart = itemNumber
            };
            return View(errorViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> InternalServer(string code)
        {
            var itemNumber = await CountItemsInCart();

            return View(new ErrorViewModel
            {
                ErrorCode = code,
                ItemsInCart = itemNumber
            });
        }

      
    }
}
