using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Adapter;
using TP7.Factory_Method;

namespace TP7
{
    public class PProxy
    {
        public static void Run()
        {
            //AlumnoProxy alumno = new AlumnoProxy();
            //alumno.Nombre = "Alejandra";

            //alumno.ResponderPregunta(1);

            //Teacher profesor = new Teacher();
            //profesor.goToClass(new AdaptadorAlumno(new ProxyToAbstract().convertir(alumno)));
            //profesor.teachingAClass();

            //Pila p = new Pila();
            //Aula a = new Aula();
            //p.setOrdenInicio(new OrdenInicio(a));
            //p.setOrdenLlegaAlumno(new OrdenLlegaAlumno(a));
            //p.setOrdenAulaLlena(new OrdenAulaLlena(a));
            //Helper.Llenar(p,"2");
            //Helper.Llenar(p, "4");

            //Console.WriteLine("Pulse una tecla para continuar...");
            //Console.ReadKey();

            Teacher teacher = new Teacher();

            IAlumno alumnoComp = (AlumnoComposite)FabricaDeComparables.CrearComparable("7");
            IAlumno alumnoComp2 = (AlumnoComposite)FabricaDeComparables.CrearComparable("7");

            Student s1 = new AdaptadorAlumno(alumnoComp);
            Student s2 = new AdaptadorAlumno(alumnoComp2);

            teacher.goToClass(s1);
            teacher.goToClass(s2);

            teacher.teachingAClass();
        }

    }
}
