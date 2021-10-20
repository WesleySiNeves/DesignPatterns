using Conceptual.Products.Contract;
using System.Drawing;


namespace Conceptual.Products
{
    public class Email : IEmail
    {
        public string Body { get; set; }

        public string From { get; set; }

        public string Subject { get; set; }

        public string To { get; set; }


        public string Rodape { get; set; }

        public Image ImagemLogo { get; set; }
    }
}
