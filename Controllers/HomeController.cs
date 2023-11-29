using ClassWork1.Helpers;
using ClassWork1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClassWork1.Controllers
{
    public class HomeController : Controller
    {


        public async Task<IActionResult> Index()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM TableData");
            return View(dt);
        }


       
    }
}