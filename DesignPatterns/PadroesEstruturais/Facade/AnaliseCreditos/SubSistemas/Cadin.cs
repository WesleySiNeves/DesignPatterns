using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseCreditos.SubSistemas
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine($"Verificando se o cliente {cliente.Nome} está no Cadin!");
            return false;
        }
    }
}
