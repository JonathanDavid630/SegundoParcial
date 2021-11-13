using SegundoParcial.Models;
using SegundoParcial.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SegundoParcial.Controllers
{
    public class Inscripcion : Controller
    {
        EnrollementsRepository ErollementsObjeto = new EnrollementsRepository();
        Erollements erollements = new Erollements();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UnionDeTablas()
        {
            var join = ErollementsObjeto.UnionDeTablas();
            return View(join);
        }
    }
}