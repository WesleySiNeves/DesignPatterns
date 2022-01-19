using VendaComputadoresComposite.Component;
using VendaComputadoresComposite.Leaf;
using System;
using VendaComputadoresComposite.Composite;

namespace VendaComputadoresComposite
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    Computador computador = new Computador { Nome = "Intel I5" };

        //    Computador gabinete = new Computador { Nome = "gabinete" };

        //    Computador periferico = new Computador { Nome = "Periféricos" };


        //    Peca discoRigido = new Peca { Nome = "Disco Rigido" };

        //    Peca PLacaMae = new Peca { Nome = "Placa Mae" };
        //    PLacaMae.Add(new Peca { Nome = "CPU", Valor = 12200 });
        //    PLacaMae.Add(new Peca { Nome = "RAM", Valor = 2100 });



        //    gabinete.Add(PLacaMae);


        //    computador.Add(discoRigido);
        //    computador.Add(gabinete);


        //    computador.GetValor();


        //    Console.ReadKey();

        //}


        static void Main(string[] args)
        {
            Computador computador = new Computador { Nome = "Intel I5" };

            Computador gabinete = new Computador { Nome = "gabinete" };

            Computador discoRigido = new Computador { Nome = "Disco Rigido" };

            Computador PlacaMae = new Computador { Nome = "Placa Mãe" };

            Computador periferico = new Computador { Nome = "Periféricos" };




            PlacaMae.Add(new Peca { Nome = "CPU", Valor = 2000 });
            PlacaMae.Add(new Peca { Nome = "Memoria ram", Valor = 2000 });

            periferico.Add(new Peca { Nome = "Mouse", Valor = 50 });
            periferico.Add(new Peca { Nome = "Teclado", Valor = 150 });



            gabinete.Add(discoRigido);
            gabinete.Add(PlacaMae);



            computador.Add(gabinete);
            computador.Add(periferico);


            computador.GetValor();


            Console.ReadKey();

        }
    }
}
