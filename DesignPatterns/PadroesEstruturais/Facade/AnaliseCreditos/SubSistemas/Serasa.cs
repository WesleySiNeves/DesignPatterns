using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseCreditos.SubSistemas
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine($"Verificando se o cliente {cliente.Nome} está no Serasa!");
            return false;

        }
    }
}
