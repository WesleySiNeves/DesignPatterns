using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Builder.Concrect
{
    /// <summary>
    /// aqui especificamos diferentes  partes da criação de um objeto
    /// </summary>
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
