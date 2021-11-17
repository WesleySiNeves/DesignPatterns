using ExampleTransacaoCartao.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Domain
{
    public class TransactionInfo
    {
        public TransactionInfo(Guid transactionKey, DateTime createDate, decimal amount, TransactionStatusType transactionStatusType)
        {
            TransactionKey = transactionKey;
            CreateDate = createDate;
            Amount = amount;
            TransactionStatusType = transactionStatusType;

        }
        public Guid TransactionKey { get; set; }

        public DateTime CreateDate { get; set; }

        public decimal Amount { get; set; }

        public TransactionStatusType TransactionStatusType { get; set; }
    }
}
