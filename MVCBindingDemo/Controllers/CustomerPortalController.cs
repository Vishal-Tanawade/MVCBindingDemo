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
            ViewBag.UserCode = Request.QueryString["code"]; // we take it that we have sent in url using ? and & and =
            ViewBag.UserName = Request.QueryString["name"];// request is HttpRequestBase class which takes data from cshtml and store in ViewBag.CustomerCode

            ViewBag.CustomerCode = Request.Form["CustomerCode"];
            ViewBag.CustomerName = Request.Form["CustomerName"];
            ViewBag.CustomerDOJ = Request.Form["CustomerDOJ"];
            ViewBag.CustomerStatus = Request.Form["CustomerStatus"];
            ViewBag.CustomerType = Request.Form["CustomerType"];


            return View();
        }

        [HttpPost]
        public ActionResult ShowDetailsWithClass(Customer customer)
        {
            ViewBag.UserCode = Request.QueryString["code"];
            ViewBag.UserName = Request.QueryString["name"];

            ViewBag.CustomerCode = customer.CustomerCode;
            ViewBag.CustomerName = customer.CustomerName;
            ViewBag.CustomerDOJ = customer.CustomerDOJ;
            ViewBag.CustomerStatus = customer.CustomerStatus;
            ViewBag.CustomerType = customer.CustomerType;

            return View();
        }

        [HttpPost]
        public ActionResult ShowDetailsStronglyType(Customer customer)
        {
            ViewBag.UserCode = Request.QueryString["code"];
            ViewBag.UserName = Request.QueryString["name"];

            // in strongly type at the time of creating view we create empty template with model customer 
            return View(customer);
        }


    }
}