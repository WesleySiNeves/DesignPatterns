using SolicitacoesCompras2.Abstract;
using SolicitacoesCompras2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitacoesCompras2.Concrect
{
    internal class VicePresident : Approver
    {
        public override void ProcessarPedidoCompra(PedidoCompra pedido)
        {
            if (pedido.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, pedido.Number);
            }
            else if (pedido != null)
            {
                successor.ProcessarPedidoCompra(pedido);
            }
        }
    }
}
