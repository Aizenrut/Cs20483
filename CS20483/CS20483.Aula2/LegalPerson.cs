using System;
using System.Collections.Generic;
using System.Text;

namespace CS20483.Aula2
{
    class LegalPerson : Person  // PessoaJuridica
    {
        public override void Print()
        {
            Console.WriteLine("Imprimindo Pessoa Juridica");
        }
    }
}
