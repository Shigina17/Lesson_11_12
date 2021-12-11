using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesoon_11_12
{
    class BankAccount
    {
        private TypeOfAccount type;
        private int balance;

        public BankAccount(TypeOfAccount type, int balance)
        {
            this.type = type;
            this.balance = balance;
        }

        public static BankAccount Current { get; internal set; }

        public enum TypeOfAccount
        {
            Current = 1,
            Saving
        }

        internal void PutOfMoneyFromAccount(BankAccount acc1, int v)
        {
            throw new NotImplementedException();
        }
    }
}
