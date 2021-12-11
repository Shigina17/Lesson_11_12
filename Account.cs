using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesoon_11_12.BankAccount;
using static Lesoon_11_12.Transactions;

namespace Lesoon_11_12
{
    class Account
    {
        Random random = new Random();
        static ulong lastNumber = 5555_9875_7777_7677;
        private List<Transactions> transactions = new List<Transactions>();
        public Transactions this[int index]
        {
            get
            {
                if (index < 0 || index >= transactions.Count)
                {
                    throw new ArgumentOutOfRangeException($"Элемент {index} - отсутствует");
                }
                return transactions[index];
            }
            set
            {
                if (index < 0 || index >= transactions.Count)
                {
                    throw new ArgumentOutOfRangeException($"Элемент {index} - отсутствует");
                }
                transactions[index] = value;
            }
        }
        public ulong Number { get; }
        public BankAccount Type { get; }
        private decimal balance;
        private TypeOfAccount current;

        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Средств на счете недостаточно, Ваш баланс: 0");
                }
                else
                {
                    balance = value;
                }
            }
        }

        internal Account(BankAccount type, decimal balance)
        {
            Type = type;
            Balance = balance;
            Number += lastNumber + (ulong)random.Next(1, 10);
            lastNumber = Number;
        }
        internal Account(BankAccount type) : this(type, 0)
        {
        }
        internal Account(decimal balance) : this(TypeOfAccount.Current, balance)
        {
        }
        internal Account() : this(TypeOfAccount.Current, 0)
        {
        }

        public Account(TypeOfAccount current, decimal balance)
        {
            this.current = current;
            this.balance = balance;
        }

        public bool Withdraw(decimal money)
        {
            if (money > Balance)
            {
                return false;
            }
            else
            {
                Balance -= money;
                transactions.Add(new Transactions(money, TypeOfTransaction.Withdraw));
                return true;
            }
        }
        public void PutMoney(decimal money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Операцию произвести невозможно. Сумма должна быть больше 0");
                transactions.Add(new Transactions(money, TypeOfTransaction.PutOfMoney));
                return;
            }
            Balance += money;
        }
        public bool PutMoneyFromAccount(Account account, decimal money)
        {
            if (!account.Withdraw(money))
            {
                return false;
            }
            else
            {
                Balance += money;
                transactions.Add(new Transactions(money, TypeOfTransaction.PutOfMoneyFromAcc));
                return true;
            }
        }
        public void Display()
        {
            Console.WriteLine("Информация о счете:\n" + $"{Type}\t{Number}\t{balance}$");
        }
        public override string ToString()
        {
            return $"{Type}\t{Number}\t{balance}$";
        }
    }
}
