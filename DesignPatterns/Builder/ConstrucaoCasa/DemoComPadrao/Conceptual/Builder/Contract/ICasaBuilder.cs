using Conceptual.Builder.Concrect;
using Conceptual.Products.Concrects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Builder.Contract
{
    public interface ICasaBuilder
    {
        CasaBuilder AddGaragem();

        CasaBuilder AddPiscina();

        CasaBuilder AddJardins();

        CasaBuilder AddObrasDeArtes();

        CasaBuilder AddQuartos(int quantidade);

        CasaBuilder AddBanheiros(int quantidade);


        Casa Build();
    }
}
