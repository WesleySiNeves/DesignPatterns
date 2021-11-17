using Conceptual.Products.Contract;
using System.Drawing;


namespace Conceptual.Products
{
    public class Email : IEmail
    {
        public string Conteudo { get; set; }

        public string De { get; set; }

        public string Assunto { get; set; }

        public string Para { get; set; }


        public string Rodape { get; set; }

        public Image ImagemLogo { get; set; }
    }
}
