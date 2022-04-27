using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorreAviacao.Mediator;

namespace TorreAviacao.Colleague
{
    public class PistaVoo : Command
    {

        private IControladorVooMediator _mediator;

        public PistaVoo(IControladorVooMediator mediator)
        {
            this._mediator = mediator;
            _mediator.setPousarStatus(true);
        }


        public void Pousar()
        {
            if (_mediator.isPousarOk())
            {
                Console.WriteLine("Aterrisado com sucesso.");
                _mediator.setPousarStatus(true);
            }
            else
                Console.WriteLine("Aguardando o pouso.");
        }

        public void getReady()
        {
            Console.WriteLine("Pronto para o pouso.");
        }
    }
}
