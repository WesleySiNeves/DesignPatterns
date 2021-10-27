using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Products.Contracts
{
    public interface ICasa
    {

        int QuantidadeQuartos { get; set; }

        int QuantidadeBanheiros { get; set; }

        bool TemGaragem { get; set; }

        bool TemJardim { get; set; }


        bool TemPiscina { get; set; }

        bool TemObrasDeArtes { get; set; }
    }
}
