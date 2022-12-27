using System;
using System.Threading.Tasks;

namespace DemoSingleton_MultiTheads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parallel.Invoke(
            //   () => AcessoThread1(),
            //   () => AcessoThread2(),
            //    () => AcessoThread3()
            //   );

            //Console.ReadLine();


            Parallel.Invoke(
               () => AcessoThread1Lock(),
               () => AcessoThread2Lock(),
                () => AcessoThread3Lock()
               );

            Console.ReadLine();

        }


        #region Acesso Sem Thread safe
        private static void AcessoThread1()
        {
            Console.WriteLine("Thread 1");
            ExemploQuantidadeInstancias s1 = ExemploQuantidadeInstancias.Instance;

            //ExemploQuantidadeInstanciasComLock s1 = ExemploQuantidadeInstanciasComLock.Instance;
            
        }

        private static void AcessoThread2()
        {
            Console.WriteLine("Thread 2");
            ExemploQuantidadeInstancias s2 = ExemploQuantidadeInstancias.Instance;
            //ExemploQuantidadeInstanciasComLock s2 = ExemploQuantidadeInstanciasComLock.Instance;

        }

        private static void AcessoThread3()
        {
            Console.WriteLine("Thread 3");
            ExemploQuantidadeInstancias s3 = ExemploQuantidadeInstancias.Instance;
            //ExemploQuantidadeInstanciasComLock s3 = ExemploQuantidadeInstanciasComLock.Instance;

        }

        #endregion


        #region Acesso Sem Thread safe
        private static void AcessoThread1Lock()
        {
            Console.WriteLine("Thread 1");
            ExemploQuantidadeInstanciasComLock s1 = ExemploQuantidadeInstanciasComLock.Instance;

        }

        private static void AcessoThread2Lock()
        {
            Console.WriteLine("Thread 2");
            
            ExemploQuantidadeInstanciasComLock s2 = ExemploQuantidadeInstanciasComLock.Instance;

        }

        private static void AcessoThread3Lock()
        {
            Console.WriteLine("Thread 3");
            ExemploQuantidadeInstanciasComLock s3 = ExemploQuantidadeInstanciasComLock.Instance;

        }
        #endregion
    }
}
