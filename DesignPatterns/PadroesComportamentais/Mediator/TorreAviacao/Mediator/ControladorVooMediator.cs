using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorreAviacao.Colleague;

namespace TorreAviacao.Mediator
{
    public class ControladorVooMediator : IControladorVooMediator
    {
        private Aviao _aviao;
        private PistaVoo _pistaVoo;
        public bool land;

        public void registerPista(PistaVoo pistaVoo)
        {
            this._pistaVoo = pistaVoo;
        }

        public void registerAviao(Aviao aviao)
        {
            this._aviao = aviao;
        }

        public bool isPousarOk()
        {
            return land;
        }
        public void setPousarStatus(bool status)
        {
            land = status;
        }
    }
}
