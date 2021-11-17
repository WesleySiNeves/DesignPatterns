using DemoVGA.Adapter;
using System;

namespace DemoVGA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Configurando o video para Monitor VDI!");

            VGAGraphicsCard vGAGraphicsCard = new VGAGraphicsCard();

            DviMonitor dviMonitor = new DviMonitor();

            VgaGraphicsCardAdapter adapter = new VgaGraphicsCardAdapter(vGAGraphicsCard);

            dviMonitor.SetInput(adapter.GetDviStream());

            Console.ReadKey();


        }
    }
}
