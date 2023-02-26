using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{
    public static class Billetera
    {
        private static List<Moneda> listaMonedas = new List<Moneda>();

        static Billetera()
        {

        }
        public static void AgregarMoneda(Moneda moneda)
        {
            try
            {
                double totalDolares = listaMonedas.Where(x => x is Dolares).Sum(x => x.ValorEnDolares);
                if (moneda is Dolares && totalDolares + moneda.ValorEnDolares > 200)
                {
                    throw new Exception("No puede comprar más de 200 dólares");
                }

                listaMonedas.Add(moneda);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void MostrarMonedas(double precioDolar)
        {
            foreach (var moneda in listaMonedas)
            {
                moneda.MostrarMoneda(precioDolar);
            }
        }

    }
}
