using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorreAviacao.Mediator;


namespace TorreAviacao.Colleague
{
    public class Aviao : Command
    {
        private IControladorVooMediator _controladorVooMediator;

       
        public Aviao(IControladorVooMediator controladorVooMediator)
        {
            this._controladorVooMediator = controladorVooMediator;
        }

        public void Pousar()
        {
            if (_controladorVooMediator.isPousarOk())
            {
                Console.WriteLine("Pouso com sucesso.");
                _controladorVooMediator.setPousarStatus(true);
            }
            else
                Console.WriteLine("Aguardando o pouso.");
        }

        public void prepararParaPousar()
        {
            Console.WriteLine("Pronto para o pouso.");
        }
    }
}
