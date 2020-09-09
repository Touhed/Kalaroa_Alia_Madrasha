using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kalaroa_Alia_Madrasha.Models;

namespace Kalaroa_Alia_Madrasha.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AdmissionContact()
        {
            return View();
        }

        public IActionResult AdmissionGuidelines()
        {
            return View();
        }

        public IActionResult AdmissionInformation()
        {
            return View();
        }

        public IActionResult ClassRoutine()
        {
            return View();
        }

        public IActionResult RulesAndRegulation()
        {
            return View();
        }

        public IActionResult Scholarship()
        {
            return View();
        }

        public IActionResult Science()
        {

            return View();
        }

        public IActionResult Arts()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
