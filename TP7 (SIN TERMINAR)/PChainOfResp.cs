using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Adapter;
using TP7.Factory_Method;

namespace TP7
{
    class PChainOfResp
    {
        public static void Run()
        {
            

            for (int i = 1;i< 5; i++)
            {
                Pila p = new Pila();
                Aula a = new Aula();
                p.setOrdenInicio(new OrdenInicio(a));
                p.setOrdenLlegaAlumno(new OrdenLlegaAlumno(a));
                p.setOrdenAulaLlena(new OrdenAulaLlena(a));

                IAlumno alumnoComp = (AlumnoComposite)FabricaDeComparables.CrearComparable("6");
                IAlumno alumnoproxy = (AlumnoComposite)FabricaDeComparables.CrearComparable("5");
                IAlumno alumnoproxy2 = (AlumnoComposite)FabricaDeComparables.CrearComparable("5");
                IAlumno alumnoproxy3 = (AlumnoComposite)FabricaDeComparables.CrearComparable("5");
                IAlumno alumnoproxy4 = (AlumnoComposite)FabricaDeComparables.CrearComparable("5");
                IAlumno alumnoproxy5 = (AlumnoComposite)FabricaDeComparables.CrearComparable("5");
            }       
        }
    }
}
