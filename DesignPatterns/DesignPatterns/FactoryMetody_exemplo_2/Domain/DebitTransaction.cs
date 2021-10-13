using ExampleTransacaoCartao.Domain.Base;
using ExampleTransacaoCartao.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Domain
{
    class DebitTransaction : TransactionBase
    {

        public string BankName { get; set; }


        public DebitTransaction(decimal amount, string bankName)
            : base(TransactionType.Debit, amount)

        {
            BankName = bankName;
         
        }
    }
}
