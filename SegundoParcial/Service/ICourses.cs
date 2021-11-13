using SegundoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Service
{
    interface ICourses
    {
        void Create(Courses c);

        void Update(Courses c);

        void Delete(Courses c);

        List<Courses> ListDataCourses();
    }
}
