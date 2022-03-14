using SolicitacoesDeCompras.Abstract;
using SolicitacoesDeCompras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitacoesDeCompras.Concrect
{
    public class President : Approver
    {
        public override void ProcessarPedidoCompra(PedidoCompra pedido)
        {
            if (pedido.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, pedido.Number);
            }
            else
            {
                Console.WriteLine(
                    "Request# {0} requires an executive meeting!",
                    pedido.Number);
            }
        }
    }
}
