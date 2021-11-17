using Escola.Adaptee;
using Escola.Domain;
using Escola.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Adapter
{
    public class AlunoAdapter : ITarget
    {
        private SistemaMensalidades sistemaMensalidade = new SistemaMensalidades();

        string Id = null;
        string Nome = null;
        string Curso = null;
        string Mensalidade = null;



        public void ProcessarCalculoMensalidade(string[,] alunosArray)
        {

            List<Aluno> alunos = new List<Aluno>();


            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = alunosArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Nome = alunosArray[i, j];
                    }
                    else if (j == 2)
                    {
                        Curso = alunosArray[i, j];
                    }
                    else
                    {
                        Mensalidade = alunosArray[i, j];
                    }

                }

                alunos.Add(new Aluno(int.Parse(Id), Nome, Curso, decimal.Parse(Mensalidade)));
            }

            sistemaMensalidade.CalcularMensalidades(alunos);

        }
    }
}
