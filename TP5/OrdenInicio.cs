using System;

namespace TP5
{
    class OrdenInicio: IOrdenEnAula1
    {
        Aula aula;
        public OrdenInicio(Aula a){
            this.aula = a;
        }
        public void Ejecutar(){
            aula.Comenzar();
        }
    }
}