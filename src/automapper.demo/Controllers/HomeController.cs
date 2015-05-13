using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using automapper.demo.Models;
using automapper.demo.service.Services;
using AutoMapper;

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

        public ActionResult MappingExampleOne()
        {
            var fooBar = FauxService.GetFooBar();
            var model = new MappingExampleOne 
            { 
                Foo = fooBar.Foo,
                Bar = fooBar.Bar
            };

            return View(model);
        }

        public ActionResult MappingExampleTwo()
        {
            var fooBar = FauxService.GetFooBar();
            var model = new MappingExampleTwo(fooBar);

            return View(model);
        }

        public ActionResult MappingExampleThree()
        {
            var fooBar = FauxService.GetFooBar();
            var model = Mapper.Map<MappingExampleTwo>(fooBar);

            return View(model);
        }


    }
}