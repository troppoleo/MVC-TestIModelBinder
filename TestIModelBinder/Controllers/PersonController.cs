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
            return View();
        }

        public ActionResult SavePerson([ModelBinder(typeof(ModelMapperPerson))] PersonCompact p) {
            PersonCompact myP = p;
            return RedirectToAction("Index");
        }

    }
}