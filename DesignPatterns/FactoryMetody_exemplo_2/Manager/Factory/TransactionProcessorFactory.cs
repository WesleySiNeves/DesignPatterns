using ExampleTransacaoCartao.Domain.ValueObject;
using ExampleTransacaoCartao.Manager.Processors;
using ExampleTransacaoCartao.Manager.Processors.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Manager.Factory
{
    public static class TransactionProcessorFactory
    {
        public static ITransactionProcessor CreateTransactionProcessor(TransactionType type)
        {
            switch (type)
            {
                case TransactionType.CreditCard: return new CredidCardTransacionProcessor();
                case TransactionType.Debit: return new DebitTransacionProcessor();
                case TransactionType.PaymentSlip: return new PaymentSlipProcessor();
                default: throw new ArgumentOutOfRangeException("Tipo de transação não configurada");
            }
        }
    }
}
