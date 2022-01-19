using AnaliseCreditos.Facade;
using AnaliseCreditos.SubSistemas;
using System;

namespace AnaliseCreditos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####################Aplicação para Conceder Emprestimo####################!");

            AnaliseCreditoFacade creditoFacade = new AnaliseCreditoFacade();

            Cliente cliente = new Cliente("Wesley Neves");

            bool result = creditoFacade.ConcederEmprestimo(cliente, 5000);


            Console.WriteLine($"Sr. Cliente {cliente.Nome} seu emprestimo foi " , result == true ? " Aprovado": "Não foi concluido.");

            Console.ReadKey();

        }
    }
}
