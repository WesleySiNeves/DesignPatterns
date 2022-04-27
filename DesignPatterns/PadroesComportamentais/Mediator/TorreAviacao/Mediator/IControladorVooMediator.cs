using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorreAviacao.Colleague;

namespace TorreAviacao.Mediator
{
    public interface IControladorVooMediator
    {
        void registerPista(PistaVoo pistaVoo);

        void registerAviao(Aviao aviao);

        bool isPousarOk();

        void setPousarStatus(bool status);
    }
}
