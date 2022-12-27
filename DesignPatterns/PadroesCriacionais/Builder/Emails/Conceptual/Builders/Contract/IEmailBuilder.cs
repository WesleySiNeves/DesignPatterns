using Conceptual.Builders.Concrect;
using Conceptual.Products;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Conceptual.Builders.Contract
{
   
    public interface IEmailBuilder
    {
        EmailBuilder Body(string body);
        EmailBuilder From(string from);

        EmailBuilder To(string to);

        EmailBuilder Subject(string subject);

        EmailBuilder MensagemRodape(string mensagem);

        EmailBuilder Logo(Image imagem);

        Email Build();


    }
}
