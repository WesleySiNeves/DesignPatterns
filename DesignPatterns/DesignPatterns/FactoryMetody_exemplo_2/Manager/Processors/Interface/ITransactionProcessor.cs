using ExampleTransacaoCartao.Domain;
using ExampleTransacaoCartao.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Manager.Processors.Interface
{
    public interface ITransactionProcessor
    {
        TransactionInfo Autorize(TransactionBase transaction);
    }
}
