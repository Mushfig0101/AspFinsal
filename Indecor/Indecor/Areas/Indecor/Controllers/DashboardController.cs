using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Indecor.Areas.Indecor.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Indecor")]

        public IActionResult Index()
        {
            return View();
        }
    }
}