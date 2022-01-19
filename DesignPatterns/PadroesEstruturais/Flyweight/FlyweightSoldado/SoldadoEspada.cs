namespace FlyweightSoldado
{
    public class SoldadoEspada : Soldado
    {
        public SoldadoEspada()
        {
            this.Tipo = TipoSoldado.Espada;
        }
        public override void RenderSoldado(string StrPriName, string Color)
        {
            Console.WriteLine($"Soldado Armado  com {Tipo.ToString()}  com nome:  { StrPriName}  Rendered with na cor  {Color}");
        }
    }
}
