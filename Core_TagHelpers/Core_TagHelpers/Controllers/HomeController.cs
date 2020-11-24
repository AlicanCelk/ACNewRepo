using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_TagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult HtmlHelperSample()
        //{
        //    return View();
        //}
        public IActionResult HtmlHelperSample() => View(); //Üsttekiyle aynı

        [HttpPost]
        public IActionResult HtmlHelperSample(User u)
        {
            return View();
        }

        public IActionResult TagHelperSample() => View();

        [HttpPost]
        public IActionResult TagHelperSample(User u)
        {
            return View();
        }

    }
}
