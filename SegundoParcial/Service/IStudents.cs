using SegundoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Service
{
    interface IStudents
    {
        void Save(Students c);

        List<Students> ListOfStudents();

        List<Students> ListDataStudents();
    }
}