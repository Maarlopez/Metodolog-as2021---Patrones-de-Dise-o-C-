namespace TP5
{
    class OrdenAulaLlena: IOrdenEnAula1
    {
        Aula aula;
        public OrdenAulaLlena(Aula a){
            this.aula = a;
        }
        public void Ejecutar(){
            aula.ClaseLista();
        } 
    }
}