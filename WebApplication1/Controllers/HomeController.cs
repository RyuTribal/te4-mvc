using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ViewResult Index2()
        {
            return View();
        }
        //"default"
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RSVP(orderResponse gr)
        {
            if (ModelState.IsValid)
            {
                return View("BetterBe", gr);
            }
            else
            {
                return View();

            }
            
        }
    }
}