using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Target
{
    public interface ITarget
    {
        void ProcessarCalculoMensalidade(string[,] alunosArray);
    }
}
