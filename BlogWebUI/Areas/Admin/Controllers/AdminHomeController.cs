﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogumUI.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
