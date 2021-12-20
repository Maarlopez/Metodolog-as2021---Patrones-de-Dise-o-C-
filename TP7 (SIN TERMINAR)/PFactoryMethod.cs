using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Factory_Method;
using TP7.Iterator;

namespace TP7
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
