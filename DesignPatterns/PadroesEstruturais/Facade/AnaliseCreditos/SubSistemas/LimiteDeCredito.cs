using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseCreditos.SubSistemas
{
    public class LimiteDeCredito
    {
        public bool PossueLimiteCredito(Cliente cliente, decimal valor)
        {
            Console.WriteLine($"Verificando se o cliente {cliente.Nome} está no Cadin!");

            if (valor > 10000)
            {
                return false;
            }

            return true;
        }
    }
}
