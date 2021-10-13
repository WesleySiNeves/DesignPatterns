using ExampleTransacaoCartao.Domain;
using ExampleTransacaoCartao.Domain.Base;
using ExampleTransacaoCartao.Domain.ValueObject;
using ExampleTransacaoCartao.Manager.Processors.Base;
using ExampleTransacaoCartao.Manager.Processors.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTransacaoCartao.Manager.Processors
{
    class DebitTransacionProcessor : ProcessorBase<DebitTransaction>, ITransactionProcessor
    {
        public TransactionInfo Autorize(TransactionBase transaction)
        {
            var credicardTransaction = ValidateTransactionType(transaction);

            return ProcessAuthorization(credicardTransaction);

        }

        private static TransactionInfo ProcessAuthorization(DebitTransaction debitTransaction)
        {

            debitTransaction.SetStatusInProgress();

            BusinessSimulation(ref debitTransaction);


            return new TransactionInfo(debitTransaction.TransactionKey,
                                        debitTransaction.CreateDate,
                                        debitTransaction.Amount,
                                        debitTransaction.StatusTypeTransaction);

        }

        private static void BusinessSimulation(ref DebitTransaction debitTransaction)
        {

            debitTransaction.TransactionKey = Guid.NewGuid();
            debitTransaction.CreateDate = DateTime.Now;


            if (debitTransaction.Amount >=10 || debitTransaction.Amount <= 1000)
            {
                debitTransaction.SetStatusAuthorized();
                return;
            }


            debitTransaction.SetStatusUnAuthorized();

        }
    }
}
