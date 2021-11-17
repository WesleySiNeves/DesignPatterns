using ExampleTransacaoCartao.Domain.Base;
using ExampleTransacaoCartao.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Domain
{
    class PaymentSlipTransaction : TransactionBase
    {
        public string DocumentNumber { get; set; }

        public string BarCode { get; set; }

        public DateTime DataVencimento { get; set; }

        public PaymentSlipTransaction(decimal amount, string documentNumber, string barCode, DateTime dueDate)
            : base(transactionType: TransactionType.PaymentSlip,amount)
            
        {
            DocumentNumber = documentNumber;
            BarCode = barCode;
            DataVencimento = dueDate;
        }
    }
}
