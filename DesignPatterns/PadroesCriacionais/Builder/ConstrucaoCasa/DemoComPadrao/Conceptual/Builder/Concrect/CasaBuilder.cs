using Conceptual.Builder.Contract;
using Conceptual.Products.Concrects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Builder.Concrect
{
    public class CasaBuilder : ICasaBuilder
    {
       private Casa product = new Casa();

        public CasaBuilder()
        {
            this.Reset();
        }

        private void Reset()
        {
            this.product = new Casa();
        }

        public CasaBuilder AddGaragem()
        {
            this.product.TemGaragem = true;

            return this;
        }

        public CasaBuilder AddJardins()
        {
            this.product.TemJardim = true;
            return this;
        }

        public CasaBuilder AddPiscina()
        {
            this.product.TemPiscina = true;
            return this;
        }

        public CasaBuilder AddObrasDeArtes()
        {
            this.product.TemObrasDeArtes = true;
            return this;
        }


        public Casa Build()
        {
            return this.product;
        }


        public CasaBuilder AddQuartos(int quantidade)
        {
            this.product.QuantidadeQuartos = quantidade;
            return this;
        }

        public CasaBuilder AddBanheiros(int quantidade)
        {
            this.product.QuantidadeBanheiros = quantidade;
            return this;
        }

    }
}
