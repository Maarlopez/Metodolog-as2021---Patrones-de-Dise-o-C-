using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    public interface IHelperComposite : IComparable
    {
        //string getNombre();
        //int getDNI();
        //int getLegajo();
        //double getPromedio();
        int getCalificacion();
        //void setNombre(string nombre);
        //void setDNI(int dni);
        //void setLegajo(int legajo);
        //void setPromedio(double promedio);
        void setCalificacion(int calif);
        //int ResponderPregunta(int pregunta);
        //string MostrarCalificacion();

    }
}
