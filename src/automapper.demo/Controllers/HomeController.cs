using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using automapper.demo.Models;
using automapper.demo.service.Services;
using AutoMapper;
using System.Web.UI;

namespace automapper.demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public JsonResult MappingExampleOne()
        {
            var fooBar = FauxService.GetFooBarExampleOne();
            var model = new MappingExampleOne 
            { 
                Foo = fooBar.Foo,
                Bar = fooBar.Bar
            };

            return Json(model, JsonRequestBehavior.AllowGet);
           
        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public JsonResult MappingExampleTwo()
        {
            var fooBar = FauxService.GetFooBarExampleTwo();
            var model = new MappingExampleTwo(fooBar);

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public JsonResult MappingExampleThree()
        {
            var fooBar = FauxService.GetFooBarExampleThree();
            var model = Mapper.Map<MappingExampleTwo>(fooBar);

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public JsonResult MappingExampleFour()
        {
            var widget = FauxService.GetWidget();
            var model = Mapper.Map<WigetModel>(widget);

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}