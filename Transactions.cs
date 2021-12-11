using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesoon_11_12
{
    class Transactions
    {
        public Transactions(decimal money, object withdraw)
        {
            Money = money;
            Withdraw = withdraw;
        }

        public decimal Money { get; }
        public object Withdraw { get; }

        public enum TypeOfTransaction
        {
            Withdraw = 1,
            PutOfMoney,
            PutOfMoneyFromAcc
        }
        public class BankTransaction
        {
            public readonly DateTime dateTime;
            public readonly decimal balance;
            public readonly TypeOfTransaction type;
            private List<BankTransaction> bankTransactions = new List<BankTransaction>();

            public BankTransaction this[int index]
            {
                get { return bankTransactions[index]; }
                set { bankTransactions[index] = value; }
            }

            public BankTransaction(decimal balance, TypeOfTransaction type)
            {
                this.type = type;
                this.balance = balance;
                dateTime = DateTime.Now;
            }
            public override string ToString()
            {
                return $"{dateTime.ToShortDateString()} {dateTime.ToLongTimeString()} {type} {balance}";
            }
        }
    }
}
