using MVCBindingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBindingDemo.Controllers
{
    public class CustomerPortalController : Controller
    {
        // GET: CustomerPortal
        public ActionResult Index()
        {
            return View();
        }

   [HttpGet]
        public ActionResult CustomerRegistration()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ShowDetails()
        {
            ViewBag.CustomerCode = Request.Form["CustomerCode"];
            ViewBag.CustomerName = Request.Form["CustomerName"];
            ViewBag.CustomerDOJ = Request.Form["CustomerDOJ"];
            ViewBag.CustomerStatus = Request.Form["CustomerStatus"];
            ViewBag.CustomerType = Request.Form["CustomerType"];


            return View();
        }


    }
}