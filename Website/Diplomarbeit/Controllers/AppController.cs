using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplomarbeit.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Download()
        {
            return View();
        }
    }
}
