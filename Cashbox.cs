using System;

namespace Project
{
    public class Cashbox
    {
        public float Balance = 0;
        private List<Transaction> transactionList = new List<Transaction>();
        public void AddTransaction(Transaction transaction)
        {
            transactionList.Add(transaction);
            Balance += transaction.Summ;
        }
    }
}