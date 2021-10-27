using Conceptual.Builder.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Directors
{
    public class CasaDirector
    {
        private ICasaBuilder _builder;

        public ICasaBuilder Builder
        {
            set { _builder = value; }
        }
       

        public void BuildCasaPadrao()
        {
            this._builder.AddQuartos(2);
            this._builder.AddBanheiros(1);

        }

        public void BuildCasaComPiscina(int quantidadeQuartos, int quantidadeBanheiros)
        {
            this._builder.AddQuartos(quantidadeQuartos);
            this._builder.AddBanheiros(quantidadeBanheiros);
            this._builder.AddPiscina();
        }
        public void BuildCasaComJardins(int quantidadeQuartos, int quantidadeBanheiros)
        {
            this._builder.AddQuartos(quantidadeQuartos);
            this._builder.AddBanheiros(quantidadeBanheiros);
            this._builder.AddJardins();
        }

        public void BuildCasaComObraDeArtes(int quantidadeQuartos, int quantidadeBanheiros)
        {
            this._builder.AddQuartos(quantidadeQuartos);
            this._builder.AddBanheiros(quantidadeBanheiros);
            this._builder.AddObrasDeArtes();
        }

        public void BuildCasaComGaragem(int quantidadeQuartos, int quantidadeBanheiros)
        {
            this._builder.AddQuartos(quantidadeQuartos);
            this._builder.AddBanheiros(quantidadeBanheiros);
            this._builder.AddGaragem();
        }
    }
}
