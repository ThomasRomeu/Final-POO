using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Moneda
    {
        public double Cantidad { get; set; }
        public virtual double ValorEnDolares
        {
            get { return Cantidad; }
        }

        public abstract void MostrarMoneda(double precioDolar);
        
        protected virtual double PrecioEnPesos(double precioDolar)
        {
            var conversion = ValorEnDolares * precioDolar;
            return conversion;
        }

        public Moneda()
        {

        }
        public Moneda(double Cantidad)
        {
            this.Cantidad = Cantidad;
        }
    }
}