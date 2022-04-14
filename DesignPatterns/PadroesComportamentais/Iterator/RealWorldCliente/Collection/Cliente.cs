using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldCliente.Collection
{
    public class Cliente
    {

        public Cliente(int id , string nome)
        {
            Id = id;
            Nome = nome;

        }
        public int Id { get; set; }

        public string Nome { get; set; }


    }
}
