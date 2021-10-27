using Conceptual.Builder.Contract;

namespace Conceptual.Directors
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildPersonagemSemPernas()
        {
            this._builder.BuildBracos();
            this._builder.BuildCabeca();
        }

        public void BuildPersonagemSemBraços()
        {
            this._builder.BuildPernas();
            this._builder.BuildCabeca();
        }

        public void BuildPersonagemCompleto()
        {
            this._builder.BuildBracos();
            this._builder.BuildPernas();
            this._builder.BuildCabeca();
        }
    }
}
