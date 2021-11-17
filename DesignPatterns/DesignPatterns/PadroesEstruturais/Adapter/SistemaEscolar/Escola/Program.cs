using Escola.Adapter;
using Escola.Target;
using System;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 4]
                {
                    { "101","Maria","Artes","100"},
                    { "102","Pedro","Engenharia","200"},
                    { "103","Bianca","Sistemas de informação","300"},
                    { "104","Pamela","Direito","400"},
                    { "105","Sergio","Medicina","500"},

                };

            ITarget target = new AlunoAdapter();

            Console.WriteLine("SistemaMensalidades passa  o array de string para o Adapter\n");

            target.ProcessarCalculoMensalidade(array);

            Console.ReadKey();

        }
    }
}
