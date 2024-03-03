using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_20_do_2_2024.classes
{
     public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public string RG { get; set; }

        public void Inserir (PessoaFisica PF){
            using(StreamWriter sw = new StreamWriter(PF.Nome+".txt")){
                sw.WriteLine($"{PF.Nome};{PF.Endereco};{PF.Valor};{PF.Taxa};{PF.Total};{PF.CPF};{PF.RG}");
            }
        }
    }
}