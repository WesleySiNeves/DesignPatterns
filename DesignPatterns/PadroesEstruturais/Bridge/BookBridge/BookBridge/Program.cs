
using BookBridge.Providers;
using System;

namespace BookBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IbookContentProvider contentProvider = new AutoBiographyAudioBookProvider();

            //IbookContentProvider contentProvider = new DesignPatternsBiographyAudioBookProvider();

            PrintBook printBook = new PrintBook(contentProvider);


            printBook.Publish();

            Console.ReadKey();


            DigitalBook digitalBook = new DigitalBook(contentProvider);


            digitalBook.Publish();

            Console.ReadKey();


            AudioBook audioBook = new AudioBook(contentProvider);


            audioBook.Publish();



        }
    }
}
