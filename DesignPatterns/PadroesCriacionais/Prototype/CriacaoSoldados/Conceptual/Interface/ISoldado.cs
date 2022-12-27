using System;

namespace Conceptual.Interface
{
    public interface ISoldado
    {
        Guid Id { get; set; }

        string Nome { get; set; }

        int Idade { get; set; }
        ShallowCopy.Acessorio Acessorio { get; set; }

    }
}
