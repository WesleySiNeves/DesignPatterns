using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSingleton
{
    public class ExemploQuantidadeInstancias
    {


        private static ExemploQuantidadeInstancias _instance;
        private static int numeroDeInstancias = 0;

        // não é

        public static ExemploQuantidadeInstancias Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new ExemploQuantidadeInstancias();
                }

                return _instance;
            }

        }

        private ExemploQuantidadeInstancias()
        {
            Console.WriteLine("Instanciando dentro do contrutor privado!\n");
            numeroDeInstancias++;
            Console.WriteLine($"Numero de instancias  ={numeroDeInstancias}\n");
        }

    }
}
