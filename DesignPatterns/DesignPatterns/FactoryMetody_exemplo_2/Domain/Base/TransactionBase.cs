using ExampleTransacaoCartao.Domain.ValueObject;
using System;
using System.Data;

namespace ExampleTransacaoCartao.Domain.Base
{
    public class TransactionBase
    {

        public Guid TransactionKey { get; set; }

        public DateTime CreateDate { get; set; }

        public TransactionType TypeTransaction { get; set; }

        public decimal Amount { get; set; }

        public TransactionBase(TransactionType transactionType, decimal amount)
        {

            Amount = amount;
            TypeTransaction = transactionType;
        }



        public TransactionStatusType StatusTypeTransaction { get; set; }

        public bool SetStatusInProgress()
        {
            StatusTransactionValidade(TransactionStatusType.InProgress);

            this.StatusTypeTransaction = TransactionStatusType.InProgress;

            return true;
        }

        public bool SetStatusAuthorized()
        {
            StatusTransactionValidade(TransactionStatusType.Authorized);

            this.StatusTypeTransaction = TransactionStatusType.Authorized;

            return true;
        }
        public bool SetStatusUnAuthorized()
        {
            StatusTransactionValidade(TransactionStatusType.UnAuthorized);

            this.StatusTypeTransaction = TransactionStatusType.UnAuthorized;

            return true;
        }

        private void StatusTransactionValidade(TransactionStatusType  statusType)
        {
            if (this.StatusTypeTransaction == statusType)
            {
                throw new ConstraintException("Não houve transição de status");
            }
            
        }
    }
}
