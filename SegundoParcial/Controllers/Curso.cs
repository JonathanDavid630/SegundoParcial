using SegundoParcial.Models;
using SegundoParcial.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SegundoParcial.Controllers
{
    public class Curso : Controller
    {
        CoursesRepository coursesRepository = new CoursesRepository();
        Courses courses = new Courses();

        StudentsRepository studentsRepository = new StudentsRepository();
        Students students = new Students();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Courses cursos)
        {
            coursesRepository.Create(cursos);
            return View("CorrectoRegistrado");
        }

        public ActionResult CorrectoRegistrado()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Combobox()
        {
            var informationofStudents = studentsRepository.ListOfStudents();
            var informationofCourse = coursesRepository.ListDataCourses();

            List<SelectListItem> ComboboxOfStudents = new List<SelectListItem>();
            List<SelectListItem> ComboboxOfCourses = new List<SelectListItem>();

            foreach (var iteracion in informationofStudents)
            {
                ComboboxOfStudents.Add(new SelectListItem
                {
                    Text = iteracion.FirstMidName,
                    Value = Convert.ToString(iteracion.StudentId)
                }
                                     );
                ViewBag.listofstudentcombobox = ComboboxOfStudents;
            }

            foreach (var iteracion in informationofCourse)
            {
                ComboboxOfCourses.Add(new SelectListItem
                {
                    Text = iteracion.Title,
                    Value = Convert.ToString(iteracion.CouserId)
                }
                                    );
                ViewBag.listofcoursescombobox = ComboboxOfCourses;
            }
            return View();
        }

        public ActionResult getcombo(Erollements e)
        {
            return View("Combobox");
        }

        [HttpGet]
        public ActionResult ServicioDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ServicioDelete(Courses cursos)
        {
            try
            {
                courses.CouserId = 1;
                coursesRepository.Delete(cursos);
            }
            catch
            {
                return Redirect("Error");
            }
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}