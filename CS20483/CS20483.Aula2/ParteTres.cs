using System;
using System.Collections.Generic;
using System.Text;

namespace CS20483.Aula2
{
    class ParteTres
    {
        public static void Executa()
        {
            SalaAula sa = new SalaAula();
            Pessoa p = new Pessoa { Nome = "Maykon", Sobrenome = "Granemann", Idade = 18 };
            sa["A1"] = p;

            Console.WriteLine( sa["A1"] );

        }
    }
}
