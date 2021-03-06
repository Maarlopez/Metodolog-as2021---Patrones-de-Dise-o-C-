using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Observer;

namespace TP5
{
    public class Vendedor : Persona, Subject
    {
        List<IObserver> gerentesObservadores = new List<IObserver>();
        public int ultimaVenta = 0;
        public Vendedor()
        {
            Bonus = 0;
        }
        public double sueldoBasico { get; set; }
        public int Bonus { get; set; }
        public void AumentaBonus()
        {
            Bonus++;
        }
        public void Venta(int monto)
        {
            Console.WriteLine("El monto de la venta fue de {0} ", monto);
            ultimaVenta = monto;
            Notificar();
        }
        public override bool sosIgual(IComparable elemento)
        {
            return this.Bonus == ((Vendedor)elemento).Bonus;
        }
        public override bool sosMenor(IComparable elemento)
        {
            return this.Bonus > ((Vendedor)elemento).Bonus;
        }
        public override bool sosMayor(IComparable elemento)
        {
            return this.Bonus < ((Vendedor)elemento).Bonus;
        }
        public void Agregar(IObserver o)
        {
            gerentesObservadores.Add(o);
        }
        public void Notificar()
        {
            foreach (IObserver gerente in gerentesObservadores)
            {
                gerente.Update(this);
            }
        }
        public void Quitar(IObserver o)
        {
            gerentesObservadores.Remove(o);
        }
    }
}
