using SegundoParcial.Models;
using SegundoParcial.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundoParcial.Repository
{
    public class StudentsRepository : IStudents
    {
        EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities(); 

        public void Save(Students c)
        {
            bd.Students.Add(c);
            bd.SaveChanges();
        }

        public List<Students> ListOfStudents()
        {
            var listadoestudiantes = bd.Students.ToList();
            return listadoestudiantes;
        }
        public List<Students> ListDataStudents()
        {
            var ListOfDataOfStudents = bd.Students.ToList();
            return ListOfDataOfStudents;
        }
    }
}