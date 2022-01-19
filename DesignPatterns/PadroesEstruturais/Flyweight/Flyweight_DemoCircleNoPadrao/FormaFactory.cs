namespace Flyweight_DemoCircleNoPadrao
{
    public class FormaFactory : IForma
    {
        private static List<IForma> formas = new List<IForma>();



        public static IForma GetForma(string chave)
        {

            IForma forma;


            if (chave == "circulo")
            {
                forma = new Circulo();
                formas.Add(forma);

            }
            else
            {
                throw new Exception("Esse tipo de objeto não pode ser criado");
            }

            return forma;

        }

    public void Desenhar()
    {

    }

    public static int GetTotalItens()
    {
        return formas.Count;
    }

    public string Tipo { get; set; }
}
}
