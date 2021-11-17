using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PadraoFactoryMethod.IProduct
{
    //Product
    public abstract class Pizza
    {
        protected Pizza()
        {
            if (Mensagens == null)
                Mensagens = new List<string>();
        }
        protected string Nome { get; set; }

        protected string Massa { get; set; }

        protected string Molho { get; set; }

        protected ArrayList ingredientes = new ArrayList();

        public List<string> Mensagens { get; set; }


        public string Preparar()
        {
            
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Preparando a pizza: {0}", Nome);
            sb.AppendFormat("\n Massa {0}", Massa);
            sb.AppendFormat("\n Mollho {0}", Molho);

            sb.AppendLine("\n Ingredientes:");
            foreach (string item in ingredientes)
            {
                sb.AppendLine("\t" + item + "");

            }
            sb.AppendLine(Cozinhar());
            sb.AppendLine(Fatiar());
            sb.AppendLine(Embalar());

            return sb.ToString();
        }

        public virtual string Cozinhar()
        {
            return "\n 30 minutos Conzinhando";
        }
        public virtual string Fatiar()
        {
            return " \n Fatiar em 8 pedaços";
        }

        public virtual string Embalar()
        {
            return " \n Embalado";
        }
    }


}
