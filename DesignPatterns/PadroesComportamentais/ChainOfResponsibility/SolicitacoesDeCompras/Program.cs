using SolicitacoesDeCompras.Abstract;
using SolicitacoesDeCompras.Concrect;
using SolicitacoesDeCompras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitacoesDeCompras
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

           

            // Generate and process purchase requests
            PedidoCompra p = new PedidoCompra(2034, 350.00, "Supplies");


            gestor.ProcessarPedidoCompra(p);

            p = new PedidoCompra(2035, 32590.10, "Project X");

            gestor.ProcessarPedidoCompra(p);


            p = new PedidoCompra(2036, 122100.00, "Project Y");
            gestor.ProcessarPedidoCompra(p);
            // Wait for user
            Console.ReadKey();
        }

       
    }
}
