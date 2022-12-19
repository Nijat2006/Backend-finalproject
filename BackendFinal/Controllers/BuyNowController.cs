using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendFinal.Controllers
{
    public class BuyNowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
