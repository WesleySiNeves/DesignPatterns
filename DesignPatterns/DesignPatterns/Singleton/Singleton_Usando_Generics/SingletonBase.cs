using System;

namespace Singleton_Usando_Generics
{

    public class SingletonBase<T> where T : class, new()
    {
        private static T _instancia;

        public static T GetInstancia()
        {
            lock (typeof(T))
            {
                if (_instancia == null)
                {
                    _instancia = new T();
                }
            }
            return _instancia;
        }
    }
    // private CadastroBusiness BusinessCadastro => SingletonBase<CadastroBusiness>.GetInstancia();

}
