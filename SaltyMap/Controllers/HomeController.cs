using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SaltyMap.Classes;
using SaltyMap.Models;
using SaltyMap.ViewModels;

namespace SaltyMap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var forcesApi = new ForcesApiHelper();
            var model = new HomeViewModel
            {
                //ForcesDatas = JsonConvert.SerializeObject(forcesApi.Gather())
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
