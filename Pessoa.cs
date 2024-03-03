using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_20_do_2_2024.classes
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public float Valor { get; set; }

        public float Taxa { get; set; }

        public float Total { get; set; }

        public virtual void Pagar (float v){
            this.Valor=v;
            this.Taxa=this.Valor*10/100;
            this.Total=this.Valor+this.Taxa;
        }
        
    }
}