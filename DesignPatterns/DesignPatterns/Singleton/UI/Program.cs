using DemoSingleton;
using System;
using System.Threading.Tasks;


namespace UI
{
    class Program
    {

        /*Implementação mais básica do Singleton */
        static void Main(string[] args)
        {


            //Primeiro exemplo
            // var exemplo_ConstrutorPrivado = new ExemploConstrutorPrivado();



            Console.WriteLine("Padrao Singleton");

            Console.WriteLine("Criando a primeira instancia");

            ExemploQuantidadeInstancias instance1 = ExemploQuantidadeInstancias.Instance;

            Console.WriteLine("Criando a segunda instancia");

            ExemploQuantidadeInstancias instance2 = ExemploQuantidadeInstancias.Instance;


            if (instance1.GetHashCode() == instance2.GetHashCode())
            {
                Console.WriteLine("Existe somente uma instancia");

            }
            else
            {
                Console.WriteLine("Instancias diferentes");
            }


            Console.ReadKey();
        }

    }
}
