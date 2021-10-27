using DemoSingleton;
using Singleton_Usando_Generics;
using System;
using System.Threading.Tasks;
using UI.Logics;

namespace UI
{
    class Program
    {
        private static ClasseLogica ClasseLogica1 => SingletonBase<ClasseLogica>.GetInstancia();

        private static ClasseLogica ClasseLogica2 => SingletonBase<ClasseLogica>.GetInstancia();

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



            Singleton_Usando_Generics();


        }

        private static void Singleton_Usando_Generics()
        {
            if (ClasseLogica1.GetHashCode() == ClasseLogica2.GetHashCode())
            {
                Console.WriteLine("Existe somente uma instancia");

            }
            else
            {
                Console.WriteLine("Instancias diferentes");
            }
        }
    }
}






