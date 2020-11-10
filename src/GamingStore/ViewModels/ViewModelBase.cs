﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingStore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingStore.ViewModels
{
    public abstract class ViewModelBase : PageModel
    {
        public int? ItemsInCart { get; set; } = null;
    }
}