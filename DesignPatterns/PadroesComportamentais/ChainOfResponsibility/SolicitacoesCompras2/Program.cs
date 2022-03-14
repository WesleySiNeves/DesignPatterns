using SolicitacoesCompras2.Abstract;
using SolicitacoesCompras2.Concrect;
using SolicitacoesCompras2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitacoesCompras2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Approver gestor = new Gestor();
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            gestor.SetSuccessor(larry);
            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);


          

            List<PedidoCompra> pedidoCompras = new List<PedidoCompra>();

            pedidoCompras.Add(new PedidoCompra(2034, 350.00, "Supplies"));

            pedidoCompras.Add(new PedidoCompra(2035, 32590.10, "Project X"));

            pedidoCompras.Add(new PedidoCompra(2036, 122100.00, "Project Y"));

            ProcessarPedidos(gestor, pedidoCompras);
           
            
            // Wait for user
            Console.ReadKey();
        }

        private static void ProcessarPedidos(Approver aprovador, List<PedidoCompra> pedidoCompras)
        {


            foreach (var pedidoCompra in pedidoCompras)
            {
                aprovador.ProcessarPedidoCompra(pedidoCompra);
            }
        }
    }
}
