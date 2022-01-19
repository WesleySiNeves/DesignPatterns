namespace FlyweightSoldadoSemPadrao
{
    /// <summary>
    /// Step 1
    /// Create an Abstract Flyweight class Soldier as:
    /// </summary>
    public abstract class Soldado
    {
        public TipoSoldado Tipo { get; set; }

        public abstract void RenderSoldado(string StrPriName, string Color);
    }

    public enum TipoSoldado
    { 
        Arma =1,
        Espada,
        Lanca,
        PowerRanger
    }
}
