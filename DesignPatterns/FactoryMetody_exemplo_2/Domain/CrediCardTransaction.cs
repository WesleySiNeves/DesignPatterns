using ExampleTransacaoCartao.Domain.Base;
using ExampleTransacaoCartao.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Domain
{
    public class CrediCardTransaction : TransactionBase
    {
        public string HolderName { get; set; }

        public string SecurityCode { get; set; }

        public string CardNumber { get; set; }

        public Int16 QuantidadeParcelas { get; set; }


        public CrediCardTransaction(decimal amount, string holderName , string secutityCode,  string cardNumber, Int16 quantidadeParcelas)
            :base(TransactionType.CreditCard,amount)
            
        {
            HolderName = holderName;
            SecurityCode = secutityCode;
            CardNumber = cardNumber;
            QuantidadeParcelas = quantidadeParcelas;
        }
    }
}
