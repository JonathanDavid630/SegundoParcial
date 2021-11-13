using SegundoParcial.Models;
using SegundoParcial.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SegundoParcial.Repository
{
    public class EnrollementsRepository : IEnrollement
    { 
        EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities();
        public List<Erollements> UnionDeTablas()
        {
            var ConsultaJoin = bd.Erollements.Include(e => e.Students).Include(c => c.Courses).ToList();
            return ConsultaJoin;
        }
    }
}