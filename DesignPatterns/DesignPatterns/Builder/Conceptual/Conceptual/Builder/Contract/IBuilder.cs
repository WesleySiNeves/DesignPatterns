using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Builder.Contract
{
    /// <summary>
    /// aqui especificamos diferentes  partes da criação de um objeto
    /// </summary>
    public interface IBuilder
    {
        void BuildBracos();

        void BuildPernas();

        void BuildCabeca();
    }
}
