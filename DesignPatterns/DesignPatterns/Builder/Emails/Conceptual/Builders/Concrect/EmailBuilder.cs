using Conceptual.Builders.Contract;
using Conceptual.Products;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Conceptual.Builders.Concrect
{
    public class EmailBuilder : IEmailBuilder
    {
        private readonly Email _email;
        public EmailBuilder()
        {
            _email = new Email();
        }

        public EmailBuilder Body(string body)
        {
            _email.Conteudo = body;
            return this;
        }
        public EmailBuilder From(string from)
        {
            _email.De = from;
            return this;
        }
        public Email Build()
        {
            return _email;
        }
        public EmailBuilder Subject(string subject)
        {
            _email.Assunto = subject;
            return this;
        }
        public EmailBuilder To(string to)
        {
            _email.Para = to;
            return this;
        }

        public EmailBuilder MensagemRodape(string mensagem)
        {
            _email.Rodape = mensagem;
            return this;
        }

        public EmailBuilder Logo(Image imagem)
        {
            _email.ImagemLogo = imagem;
            return this;
        }
    }
}
