using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Conceptual.Products.Contract
{
    public interface IEmail
    {

        string Body { get; set; }

        string From { get; set; }

        string Subject { get; set; }

        string To { get; set; }


        string Rodape { get; set; }

        Image ImagemLogo { get; set; }
    }
}
