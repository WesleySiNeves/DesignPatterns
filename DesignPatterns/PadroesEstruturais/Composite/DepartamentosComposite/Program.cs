using DepartamentosComposite.Composite;
using DepartamentosComposite.Leaf;
using System;

namespace DepartamentosComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Organizacao organizacao = new Organizacao { Nome = "Implanta" };


            Organizacao departamentoTI = new Organizacao { Nome = "TI" };


            departamentoTI.Add(new Funcionario { Id = 1, Nome = "TI_A", Horas = 8 });
            departamentoTI.Add(new Funcionario { Id = 2, Nome = "TI_B", Horas = 7 });
            departamentoTI.Add(new Funcionario { Id = 3, Nome = "TI_C", Horas = 8 });

            Organizacao departamentoContabilidade = new Organizacao { Nome = "Contabilidade" };


            departamentoContabilidade.Add(new Funcionario { Id = 1, Nome = "CONT_A", Horas = 8 });
            departamentoContabilidade.Add(new Funcionario { Id = 2, Nome = "CONT_B", Horas = 8 });
            departamentoContabilidade.Add(new Funcionario { Id = 3, Nome = "CONT_C", Horas = 7 });



            organizacao.Add(departamentoTI);

            organizacao.Add(departamentoContabilidade);

            organizacao.GetHorasTrabalhadas();

            Console.ReadKey();


        }
    }
}
