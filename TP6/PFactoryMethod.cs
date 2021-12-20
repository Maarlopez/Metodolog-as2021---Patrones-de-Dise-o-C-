using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Factory_Method;
using TP6.Iterator;

namespace TP6
{
    class PFactoryMethod
    {
        public static void Run()
        {
            Coleccionable UnColeccion = new Cola();
            Helper.Llenar(UnColeccion, "2");
            Helper.Informar(UnColeccion);
            Helper.ImprimirElementos(UnColeccion);

        }
    }
}
