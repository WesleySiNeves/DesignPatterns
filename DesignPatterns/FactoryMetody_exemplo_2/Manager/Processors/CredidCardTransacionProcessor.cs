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
    class CredidCardTransacionProcessor : ProcessorBase<CrediCardTransaction>, ITransactionProcessor
    {
        public TransactionInfo Autorize(TransactionBase transaction)
        {
            var credicardTransaction = ValidateTransactionType(transaction);

            return ProcessAuthorization(credicardTransaction);

        }

        private static TransactionInfo ProcessAuthorization(CrediCardTransaction crediCardTransaction)
        {

            crediCardTransaction.SetStatusInProgress();

            BusinessSimulation(ref crediCardTransaction);


            return new TransactionInfo(crediCardTransaction.TransactionKey,
                                        crediCardTransaction.CreateDate,
                                        crediCardTransaction.Amount,
                                        crediCardTransaction.StatusTypeTransaction);

        }


        private static void BusinessSimulation(ref CrediCardTransaction crediCardTransaction)
        {
            crediCardTransaction.TransactionKey = Guid.NewGuid();
            crediCardTransaction.CreateDate = DateTime.Now;


            if (crediCardTransaction.Amount >= 10 && crediCardTransaction.Amount <= 1000)
            {
                crediCardTransaction.SetStatusAuthorized();
                return;
            }


            crediCardTransaction.SetStatusUnAuthorized();

        }

    }
}
