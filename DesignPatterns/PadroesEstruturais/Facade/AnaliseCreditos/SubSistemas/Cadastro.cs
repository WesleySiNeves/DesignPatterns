using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseCreditos.SubSistemas
{
    public class Cadastro
    {

        public void CadastrarCliente( Cliente cliente)
        {
            Console.WriteLine($"Cadastro do cliente {cliente.Nome} concluido com sucesso!");
        
        }
    }
}
