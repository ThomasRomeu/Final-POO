using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{
    public sealed class Crypto : Moneda
    {
        public Cryptos tipoDeCrypto { get; set; }
        public enum Cryptos
        {
            Ethereum,
            Bitcoin
        }

        public Crypto()
        {

        }
        public Crypto(Cryptos tipoDeCrypto)
        {
            this.tipoDeCrypto = tipoDeCrypto;
        }

        public override double ValorEnDolares
        {
            get
            {
                if (tipoDeCrypto == Cryptos.Ethereum)
                {
                    return base.Cantidad * 1200;
                }
                else if (tipoDeCrypto == Cryptos.Bitcoin)
                {
                    return base.Cantidad * 17000;
                }
                else
                    return base.Cantidad;
            }
        }

        public override void MostrarMoneda(double precioDolar)
        {
            Console.WriteLine("Tipo de crypto: " + this.tipoDeCrypto + " | " + "Cantidad de Cryptos: " + this.Cantidad + " | " + "Cotizacion en Dolares: " + this.ValorEnDolares + " | " + "Cotizacion en Pesos: " + base.PrecioEnPesos(precioDolar));
        }
    }
}