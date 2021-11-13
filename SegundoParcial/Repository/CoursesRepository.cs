using SegundoParcial.Models;
using SegundoParcial.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundoParcial.Repository
{
    public class CoursesRepository : ICourses
    {
        EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities();

        public void Create(Courses c)
        {
            bd.Courses.Add(c);
            bd.SaveChanges();
        }

        public void Delete(Courses c)
        {
            c = bd.Courses.Find(c.CouserId);
            _ = c;
            bd.Courses.Remove(c);
            bd.SaveChanges();
        }

        public List<Courses> ListDataCourses()
        {
            var ListOfDataOfCourse = bd.Courses.ToList();

            return ListOfDataOfCourse;
        }

        void ICourses.Update(Courses c)
        {
            Courses datosactualizar = new Courses();
            datosactualizar = bd.Courses.Find(c.CouserId);
            datosactualizar.Title = c.Title;
            bd.SaveChanges();
        }

        public static implicit operator CoursesRepository(StudentsRepository v)
        {
            throw new NotImplementedException();
        }
    }
}