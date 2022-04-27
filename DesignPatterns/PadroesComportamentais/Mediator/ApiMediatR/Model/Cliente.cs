namespace ApiMediatR.Model
{
    public class Cliente : ICliente
    {
        public Guid Id { get; set; }

        public string Name { get; set; }    
    }

    public interface ICliente
    {
         Guid Id { get; set; }

         string Name { get; set; }
    }
}
