using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Factory_Method
{
    public abstract class FabricaDeComparables
    {
        public abstract Comparable CrearComparable();

        public static Comparable CrearComparable(string option) //crear aleatorio
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
            }
            return FM.CrearComparable();
        }
    }
}
