using System;
using System.Collections.Generic;
using System.Text;

namespace CS20483.Aula2
{
    class SalaAula
    {
        public Pessoa this[string chave] 
        {
            get 
            {
                return this.assentos[chave];
            }
            set 
            {
                this.assentos.Add(chave, value);
            } 
        }
        public int this[string chave, int chave2]
        {
            get
            {
                return 0;
            }
            set
            {
                this.idade = value;
            }
        }
        private int idade =0 ;
        private IDictionary<string, Pessoa> assentos = new Dictionary<string, Pessoa>();

    }
}
