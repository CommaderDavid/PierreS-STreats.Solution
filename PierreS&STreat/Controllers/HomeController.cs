
using Microsoft.AspNetCore.Mvc;
using PierreS_STreat.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierreS_STreat.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}