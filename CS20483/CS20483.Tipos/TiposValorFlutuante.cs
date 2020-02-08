using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class TiposValorFlutuante
    {
        public void Executa()
        {
            Console.WriteLine("Tipos por valor");

            Console.WriteLine("Tipos Flutuantes:");
            //5.9722 × 10 24
            float massa_terra = 5.9722e24f;
            Console.WriteLine($"Tipo Float:{Single.MinValue} - {float.MaxValue}");

            //1,989 × 10^30 kg
            double massa_sol = 1.989e30;
            Console.WriteLine($"Tipo Double:{Double.MinValue} - {double.MaxValue}");

            //==== Ponto flutuante para se trabalhar com valores monetários
            decimal dinheiro = 4.578m;
            Console.WriteLine($"Tipo Decimal:{Decimal.MinValue} - {decimal.MaxValue}");

        }
    }
}
