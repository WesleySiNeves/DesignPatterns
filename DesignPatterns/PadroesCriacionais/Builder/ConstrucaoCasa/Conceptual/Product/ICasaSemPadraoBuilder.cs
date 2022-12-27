using System;
using System.Collections.Generic;
using System.Text;

namespace ContrucaoCasaUISemPadraoCode.Product
{
    public interface ICasaSemPadraoBuilder
    {
        int QuantidadeQuartos { get; set; }

        int QuantidadeBanheiros { get; set; }

        bool Temgaragem { get; set; }

        bool TemJardim { get; set; }


        bool TemPiscina { get; set; }

        bool TemObrasDeArtes { get; set; }


    }
}
