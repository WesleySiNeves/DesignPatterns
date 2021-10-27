using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Conceptual.Products.Contract
{
    public interface IEmail
    {

        string Conteudo { get; set; }

        string De { get; set; }

        string Assunto { get; set; }

        string Para { get; set; }


        string Rodape { get; set; }

        Image ImagemLogo { get; set; }
    }
}
