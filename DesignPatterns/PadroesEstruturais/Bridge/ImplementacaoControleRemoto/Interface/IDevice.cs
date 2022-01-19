using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementacaoControleRemoto.Interface
{

    // A interface "implementação" declara métodos comuns a todas as
    // classes concretas de implementação. Ela não precisa coincidir
    // com a interface de abstração. Na verdade, as duas interfaces
    // podem ser inteiramente diferentes. Tipicamente a interface de
    // implementação fornece apenas operações primitivas, enquanto
    // que a abstração define operações de alto nível baseada
    // naquelas primitivas.
    public interface IDevice
    {
        bool isEnabled();

        bool enable();

        bool disable();

        int getVolume();

        void setVolume(int volume);

        decimal getChannel();

        void setChannel(decimal channel);
    }
}
