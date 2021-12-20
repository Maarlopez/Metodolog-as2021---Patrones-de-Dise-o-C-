using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Proxy;

namespace TP6.Adapter
{
    class ProxyToAbstract
    {
        Alumno Alumno = new Alumno();

        public Alumno convertir(AlumnoProxy alumno)
        {
            Alumno.Nombre = alumno.Nombre;
            return Alumno;
        }

    }
}
