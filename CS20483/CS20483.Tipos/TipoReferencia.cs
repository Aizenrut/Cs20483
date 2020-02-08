using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Tipos
{
    public class TipoReferencia
    {
        public void Executa()
        {
            Console.WriteLine("Tipos por referencia - Classe");
            PessoaClasse p = new PessoaClasse { Nome="Chimba", Idade=30 };
            var p2 = new PessoaClasse();
            
            object p3 = new PessoaClasse();
            
            Console.WriteLine($"Class Pessoa: {p}");
        }
    }
    public class PessoaClasse
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{this.Nome}-{this.Idade}";
        }

    }
}
