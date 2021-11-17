using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Domain.ValueObject
{
    public enum TransactionType
    {
        CreditCard  = 0,
        Debit =1,
        PaymentSlip  =2
    }
}
