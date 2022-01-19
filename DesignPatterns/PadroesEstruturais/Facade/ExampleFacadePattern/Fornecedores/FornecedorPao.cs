using ExampleFacadePattern.Interfaces;
using System;

namespace ExampleFacadePattern.Fornecedores
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoAlho()
        {
            Console.WriteLine("Obtendo Pão de alho");
        }

        public void BuscarPaoAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Obtendo Pão de alho com queijo");
        }

        private void ObterQueijo()
        {
            Console.WriteLine("Obtendo queijo");
        }
    }
}
