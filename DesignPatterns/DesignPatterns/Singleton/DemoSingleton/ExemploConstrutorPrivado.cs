
namespace DemoSingleton
{
    /// <summary>
    /// Descomentar esse codigo para ver a implementação correta do singleton (usando contrutor privado)
    /// </summary>
    public class ExemploConstrutorPrivado
    {
        private CreditosBancariosBusiness _business;

        public CreditosBancariosBusiness BusinessCreditosBancarios
        {

            get
            {
                if (_business == null)
                {
                    _business =  CreditosBancariosBusiness.Instance;

                    
                }

                return _business;

            }
        }
    }
}
