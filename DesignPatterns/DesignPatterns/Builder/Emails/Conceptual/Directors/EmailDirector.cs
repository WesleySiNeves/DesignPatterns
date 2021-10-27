using Conceptual.Builders.Contract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Conceptual.Directors
{
    public class EmailDirector
    {
        private IEmailBuilder _builder;

        

        public void SetBuilder(IEmailBuilder builder)
        {
            this._builder = builder;
        }


        public void BuildIEmailSimples(string to, string from, string subject, string conteudo)
        {
            this._builder
                .To(to)
                .From(from)
                .Subject(subject)
                .Body(conteudo)
                .Build();
        }
        public void BuildIEmailComImagem(string to, string from, string subject, string conteudo, Image imagem)
        {
            this._builder
                .To(to)
                .From(from)
                .Subject(subject)
                .Body(conteudo)
                .Logo(imagem)
                .Build();
        }

        public void BuildIEmailSemImagemEComRodape(string to, string from, string subject, string conteudo, string rodape)
        {
            this._builder
                .To(to)
                .From(from)
                .Subject(subject)
                .Body(conteudo)
                .MensagemRodape(rodape)
                .Build();
        }

        public IEmailBuilder GetEmail()
        {
            return this._builder;
        }
    }
}
