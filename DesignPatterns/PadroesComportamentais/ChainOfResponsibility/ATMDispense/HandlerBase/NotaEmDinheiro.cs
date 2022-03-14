using ATMDispense.Concrect;

namespace ATMDispense.HandlerBase
{
    public class NotaEmDinheiro
    {
        private NotaEmDinheiro next = NotaEmDinheiro.Zero; 
        private static readonly NotaEmDinheiro Zero;

        public int Denomination { get; }
        public int Quantity { get; }

     
        static NotaEmDinheiro()
        {
            Zero = new ZeroCurrencyBill();
        }

        public NotaEmDinheiro(int denomination, int quantity)
        {
            Denomination = denomination;
            Quantity = quantity;
        }

        //Method that set next handler in the pipeline
        public NotaEmDinheiro GetProximaNota(NotaEmDinheiro currencyBill)
        {
            next = currencyBill;
            return next;
        }

        public virtual bool DispenseRequest(int amount)
        {
            if (amount >= Denomination)
            {
                var num = Quantity;
                var remainder = amount;
                while (remainder >= Denomination && num > 0)
                {
                    remainder -= Denomination;
                    num--;
                }

                if (remainder != 0)
                {
                    return next.DispenseRequest(remainder);
                }

                return true;
            }
            else
            {
                return next.DispenseRequest(amount);
            }

        }
    }



}

