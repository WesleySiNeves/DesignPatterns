using FabricaCarrosUI.Conceitual;
using System;
using System.Collections.Generic;

namespace FabricaCarrosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int sair = -1;

            while (sair != 0)
            {
                Console.WriteLine(" ######## Digite 0 para sair: #############\n");
                sair = int.Parse(Console.ReadLine());

                if (sair == 0)
                    break;
                
                Console.WriteLine("Digite a quantidade de carros que queria construir:");

                int quantidade = int.Parse(Console.ReadLine());


                Console.WriteLine("Digite 1 para clonar e 2 para criar(new):");

                int opcao = int.Parse(Console.ReadLine());

               

                if (opcao == 1)
                {
                    List<Carro> listaCarros = new List<Carro>();

                    var carroPai = CriarCarro();

                    for (int i = 0; i < quantidade; i++)
                    {
                        var newCarro = carroPai.ShallowCopy();
                        newCarro.Chassi = Guid.NewGuid();

                        listaCarros.Add(newCarro);
                    }

                    Empty(listaCarros);
                }
                else if (opcao == 2)
                {
                    List<Carro> listaCarros = new List<Carro>();

                    var carroPai = CriarCarro();

                    for (int i = 0; i < quantidade; i++)
                    {
                        var newCarro = new Carro(chassi: Guid.NewGuid());
                        newCarro.Marca = carroPai.Marca;
                        newCarro.Modelo = carroPai.Modelo;
                        newCarro.Ano = carroPai.Ano;


                        listaCarros.Add(newCarro);
                    }

                    Empty(listaCarros);

                }


              


                Console.ReadLine();
            }
            
        }

        public static Carro CriarCarro()
        {
            var carroPai = new Carro(chassi: Guid.NewGuid());
            carroPai.Ano = Util.RandonUtil.GetRandonInt(1987, 2022);
            carroPai.Marca = "Volkswagen";
            carroPai.Modelo = "Gol";

            return carroPai;
        }

        public static void Empty(List<Carro> lista)
        {
            lista.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
    }
}
