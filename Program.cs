using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesoon_11_12.BankAccount;

namespace Lesoon_11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("пример 1");
            BankAccount acc1 = new BankAccount(type: TypeOfAccount.Current, balance: 77000);
            BankAccount acc2 = new BankAccount(type: TypeOfAccount.Saving, balance: 13500);
            acc2.PutOfMoneyFromAccount(acc1, 7000);
            Console.WriteLine(acc1);
            Console.WriteLine(acc1[0]);
            Console.WriteLine(acc2);
            Console.WriteLine(acc2[0]);

            Console.WriteLine("пример 2");
            TenBuildings decade = new TenBuildings();
            for (int i = 0; i < 10; i++)
            {
                decade[i] = new Building(height: 25 + i, numStoreys: 5 + i, numEntrance: 2 + i, numFlats: 10 + i);
                Console.WriteLine(decade[i]);
            }
            Console.ReadKey();
        }
    }
}
