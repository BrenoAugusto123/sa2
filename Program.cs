// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
namespace atividade_20_do_2_2024.classes{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            Console.WriteLine(@"
 1-Cadastrar Pessoa Juridica
 2-Cadastrar Pessoa Fisica
 3- Sair
 
");

            opcao = Console.ReadLine();

            if (!string.IsNullOrEmpty(opcao))
            {
                if (opcao == "1")
                {
                    PessoaJuridica PJ = new PessoaJuridica();
                    Console.WriteLine("Nome:");
                    PJ.Nome = Console.ReadLine();

                    Console.WriteLine("CNPJ:");
                    PJ.CNPJ = Console.ReadLine();

                    Console.WriteLine("Endereco:");
                    PJ.Endereco = Console.ReadLine();

                    Console.WriteLine("IE:");
                    PJ.IE = Console.ReadLine();

                    Console.WriteLine("Valor:");
                    if (float.TryParse(Console.ReadLine(), out float valor))
                    {
                        PJ.Valor = valor;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Insira um número.");
                        return;
                    }

                    
                     PJ.Pagar(1);
                     PJ.Inserir(PJ);
                     
                }
                else if (opcao == "2")
                {
                    PessoaFisica PF = new PessoaFisica();
                    Console.WriteLine("Nome:");
                    PF.Nome = Console.ReadLine();

                    Console.WriteLine("CPF:");
                    PF.CPF = Console.ReadLine();

                    Console.WriteLine("Endereco:");
                    PF.Endereco = Console.ReadLine();

                    Console.WriteLine("RG:");
                    PF.RG = Console.ReadLine();

                    Console.WriteLine("Valor:");
                    if (float.TryParse(Console.ReadLine(), out float valor))
                    {
                        PF.Valor = valor;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Insira um número.");
                        return;
                    }

                  

                     PF.Pagar(1);
                     PF.Inserir(PF);
                     
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}
