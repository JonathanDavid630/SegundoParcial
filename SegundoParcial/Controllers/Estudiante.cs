using SegundoParcial.Models;
using SegundoParcial.Models.ViewModels;
using SegundoParcial.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SegundoParcial.Controllers
{
    public class Estudiante : Controller
    {
        public ActionResult Registros()
        {
            return View();
        }

        CoursesRepository coursesRepository = new CoursesRepository();
        Courses courses = new Courses();

        StudentsRepository studentsRepository = new StudentsRepository();
        Students students = new Students();

        public ActionResult Index()
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

        [HttpPost]
        public ActionResult getcombo(Erollements e)
        {
            return View("Combobox");
        }

        public ActionResult Registrados()
        {
            return View();
        }

        public ActionResult Registradoss([Bind(Include = "StudentID")] FilterInfo info)
        {
            StudentsRepository studentsRepository = new StudentsRepository();
            if (ModelState.IsValid)
            {
                studentsRepository.Save(students);
                return View("Registrados", students);
            }
            else
                return View("Registros");
        }

      

        public ActionResult Registross(Students students)
        {
            StudentsRepository studentsRepository = new StudentsRepository();

            studentsRepository.Save(students);

            var ListOfData = studentsRepository.ListDataStudents();

            return View(ListOfData);
        }
    }
}