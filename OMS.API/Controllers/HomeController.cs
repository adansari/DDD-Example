﻿using Microsoft.AspNetCore.Mvc;

namespace OMS.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
