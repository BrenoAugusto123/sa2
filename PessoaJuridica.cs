using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_20_do_2_2024.classes
{
     public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public string IE { get; set; }
        public override void Pagar (float v){
            this.Valor=v;
            this.Taxa=this.Valor*20/100;
            this.Total=this.Valor+this.Taxa;
    
        }
        public void Inserir (PessoaJuridica PJ){
            using(StreamWriter sw = new StreamWriter(PJ.Nome+".txt")){
                sw.WriteLine($"{PJ.Nome};{PJ.Endereco};{PJ.Valor};{PJ.Taxa};{PJ.Total};{PJ.CNPJ};{PJ.IE}");
            }
        }
        
    }
}