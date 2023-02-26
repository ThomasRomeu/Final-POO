using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{

    public sealed class Dolares : Moneda
    {
        protected override double PrecioEnPesos(double precioDolar)
        {
            return base.ValorEnDolares * precioDolar * 1.30;
        }

        public override void MostrarMoneda(double precioDolar)
        {
            Console.WriteLine("Dolares: " + base.ValorEnDolares + " | " + "Cotizacion en Pesos: " + this.PrecioEnPesos(precioDolar));
        }

        public Dolares(double Cantidad) : base(Cantidad)
        {

        }
    }

}