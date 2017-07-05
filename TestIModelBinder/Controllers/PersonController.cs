using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestIModelBinder.Models;
using TestIModelBinder.Models.Mapper;

namespace TestIModelBinder.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            // lettura dell'error message
            ViewBag.Title = Resource.TITLE;
            return View();
        }


        [ValidateAntiForgeryToken]
        public ActionResult SavePerson([ModelBinder(typeof(ModelMapperPerson))] PersonCompact p)
        {
            if (ModelState.IsValid)
            {
                PersonCompact myP = p;
            }
            return RedirectToAction("Index");
        }


    }
}