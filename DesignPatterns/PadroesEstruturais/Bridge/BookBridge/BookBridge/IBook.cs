using System;
using System.Collections.Generic;
using System.Text;

namespace BookBridge
{
    /// <summary>
    /// Implementador   
    /// define a interface para classes de implementação. Essa interface não precisa corresponder exatamente à interface do Abstraction;
    /// na verdade, as duas interfaces podem ser bastante diferentes. Normalmente, a interface de Implementação fornece apenas operações primitivas,
    /// e Abstração define operações de nível superior com base nessas primitivas.
    /// </summary>
    public interface IBook
    {
        void Publish();
    }
}
