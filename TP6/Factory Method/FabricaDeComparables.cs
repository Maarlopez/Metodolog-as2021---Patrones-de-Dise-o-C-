using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Factory_Method
{
    public abstract class FabricaDeComparables
    {
        public abstract IComparable CrearComparable();

        public static IComparable CrearComparable(string option) //crear aleatorio
        {
            FabricaDeComparables FM = null;
            switch(option)
            {
                case "1": FM = new FabricaDeNumeros();
                    break;
                case "2":
                    FM = new FabricaDeAlumnos();
                    break;
                case "3":
                    FM = new FabricaDeVendedores();
                    break;
                case "4":
                    FM = new FabricaDeAlumnosMuyEstudiosos();
                    break;
                case "5":
                    FM = new FabricaDeAlumnosProxy();
                    break;
                case "6":
                    FM = new FabricaAlumnosCompuestos();
                    break;
                case "7":
                    FM = new FabricaDeTodos();
                    break;
            }
            return FM.CrearComparable();
        }
    }
}
