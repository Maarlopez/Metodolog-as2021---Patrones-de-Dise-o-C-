using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Factory_Method;
using TP3.Iterator;

namespace TP3
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
