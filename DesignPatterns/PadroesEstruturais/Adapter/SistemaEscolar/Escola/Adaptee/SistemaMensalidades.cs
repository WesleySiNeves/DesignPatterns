using Escola.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Adaptee
{
    public class SistemaMensalidades
    {
        public void CalcularMensalidades(List<Aluno> alunos)
        {

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno {aluno.Nome} \t Mensalidade $: {aluno.Mensalidade}");
            }
        }

    }
}
