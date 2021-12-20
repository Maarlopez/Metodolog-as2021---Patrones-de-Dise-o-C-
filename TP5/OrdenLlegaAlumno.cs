using System;
using TP5;

namespace TP5
{
    class OrdenLlegaAlumno: IOrdenEnAula2
    {
        Aula aula;
        public OrdenLlegaAlumno(Aula a){
            this.aula = a;
        }
        public void Ejecutar(IComparable comparable){
            aula.nuevoAlumno(comparable);
        }    
    }
}