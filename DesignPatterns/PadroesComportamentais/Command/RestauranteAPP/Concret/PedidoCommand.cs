using RestauranteAPP.Interface;
using RestauranteAPP.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPP.Concret
{
    public class PedidoCommand : Command
    {

        private Cheff Chef { get; set; }

        private string Acao { get; set; }


        public PedidoCommand(Cheff cheff , string acao)
        {
            Chef = cheff;
            Acao = acao;

        }
        public override void Execute()
        {

            if (Acao.Equals("Prato"))
            {
                Chef.PrepararPrato();
            }
            else
            {
                Chef.PrepararSobremesa();
            }
            
        }
    }
}
