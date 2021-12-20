using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Adapter;
using TP5.Iterator;
using TP5.Proxy;

namespace TP5
{
    public class PProxy
    {
        public static void Run()
        {
            AlumnoProxy alumno = new AlumnoProxy();
            alumno.Nombre = "Alejandra";

            alumno.ResponderPregunta(1);

            Teacher profesor = new Teacher();
            profesor.goToClass(new AdaptadorAlumno(new ProxyToAbtract().convertir(alumno)));
            profesor.teachingAClass();


        }

    }
}
