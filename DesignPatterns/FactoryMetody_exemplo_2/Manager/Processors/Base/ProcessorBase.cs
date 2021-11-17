using ExampleTransacaoCartao.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Manager.Processors.Base
{
    public abstract class  ProcessorBase<T> where T: TransactionBase
    {
        protected T ValidateTransactionType(TransactionBase transactionBase)
        {
            if (!(transactionBase is T)) throw new ArgumentException("Tipo de transação inválida");

            return (T)transactionBase;
        }
    }
}
