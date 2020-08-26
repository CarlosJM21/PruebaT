using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaT.Web.Helpers;
using PruebaT.Web.Models;
using PruebaT.Web.ViewModels;

namespace PruebaT.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ITorreHelper _torreHelper;

        public HomeController(ITorreHelper torreHelper)
        {
            _torreHelper = torreHelper;
        }

        public async Task<IActionResult> Index()
        {
            var s = new IndexViewModel 
            {
                People= await _torreHelper.searchpeople(null, null, null),
                Jobs= await _torreHelper.searchoppt(null,null,null),
                Tab = 1
            };

            return View(s);
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Bio(String id)
        {
          
            return View(await _torreHelper.bio(id));
        }

        public async Task<IActionResult> Oppotunity(String id)
        {
  
            return View(await _torreHelper.Job(id));
        }

    }
}
