using ATMDispense.HandlerBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDispense.Concrect
{
    public class ZeroCurrencyBill : NotaEmDinheiro
    {
        public ZeroCurrencyBill() : base(0, 0)
        {
        }

        public override bool DispenseRequest(int amount)
        {
            return false;
        }
    }
}
