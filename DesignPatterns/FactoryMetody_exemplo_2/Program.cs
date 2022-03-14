using ExampleTransacaoCartao.Domain;
using ExampleTransacaoCartao.Domain.ValueObject;
using ExampleTransacaoCartao.Manager.Factory;
using System;

namespace ExampleTransacaoCartao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  CreditCardTransaction

            var creditCardProcessor = TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.CreditCard);

            var transacao = new CrediCardTransaction(50000, "Wesley Neves", "999", "12345678911", quantidadeParcelas: 10);


            var transacaoInfo = creditCardProcessor.Autorize(transacao);

            Console.WriteLine($"{transacaoInfo.Amount} |  {transacaoInfo.CreateDate:g} | {transacaoInfo.TransactionKey} | {transacaoInfo.TransactionStatusType} ");

            #endregion


            #region  DebitTransaction

            var debitCardProcessor = TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.Debit);

            var transacaoDebit = new DebitTransaction(1000, "Banco do Brasil");


            var transacaoDebitInfo = debitCardProcessor.Autorize(transacaoDebit);

            Console.WriteLine($"{transacaoDebitInfo.Amount} |  {transacaoDebitInfo.CreateDate:g} | {transacaoDebitInfo.TransactionKey} | {transacaoDebitInfo.TransactionStatusType} ");

            #endregion
        }
    }
}
