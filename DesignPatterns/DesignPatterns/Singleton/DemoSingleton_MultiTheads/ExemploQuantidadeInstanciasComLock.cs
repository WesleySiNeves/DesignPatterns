using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSingleton_MultiTheads
{
    public class ExemploQuantidadeInstanciasComLock
    {


        private static ExemploQuantidadeInstanciasComLock _instance;
        private static int numeroDeInstancias = 0;

        /* Inplementação correta para mult-Theads*/


        private static object Lock_me = new object();


        public static ExemploQuantidadeInstanciasComLock Instance
        {

            get
            {
                lock (Lock_me)
                {
                    if (_instance == null)
                    {
                        _instance = new ExemploQuantidadeInstanciasComLock();
                    }

                }

                return _instance;
            }

            ///*Forma de dupla verificação e diminuição de locks de objetos*/
            //get
            //{
            //    if (_instance != null) return Instance;

            //    lock (Lock_me)
            //    {
            //        if (_instance == null)
            //        {
            //            _instance = new ExemploQuantidadeInstanciasComLock();
            //        }

            //    }
            //    return _instance;
            //}


        }


        private ExemploQuantidadeInstanciasComLock()
        {
            Console.WriteLine("Instanciando dentro do contrutor privado!\n");
            numeroDeInstancias++;
            Console.WriteLine($"Numero de instancias  ={numeroDeInstancias}\n");
        }

    }
}
