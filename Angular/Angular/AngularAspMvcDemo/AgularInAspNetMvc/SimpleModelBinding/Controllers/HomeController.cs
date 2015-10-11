﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleModelBinding.Models;

namespace SimpleModelBinding.Controllers
{
    public class HomeController : Controller
    {
        //0
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //1
        public ActionResult WithController()
        {
            return View();
        }

        //2
        public ActionResult Basket()
        {
            return View();
        }

        //3
        public ActionResult SimpleForm()
        {
            return View();
        }

        //4
        public ActionResult WithServices()
        {
            return View();
        }

        public JsonResult GetPerson(int id)
        {
            var person = new Person {FirstName = "Bob", LastName = "Smith", UserName = "BSmith", Number = 3};

            return Json(person, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void SavePerson(Person person)
        {
            return;
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}