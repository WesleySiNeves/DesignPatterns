using RestauranteAPP.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPP.Invoker
{
    public class Garcon
    {
        private PedidoCommand _pedido;


        public Garcon(PedidoCommand  pedido)
        {
             _pedido = pedido;
                
        }
        public void Executar()
        {
            _pedido.Execute();
        }
    }
}
