using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class DependencyInjectionCsharp
    {
        public interface IAccount
        {
            void PrintDetails();
        }

        class CurrentAccount :IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of Current Account");
            }
        }

        class SavingAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of Saving Account");
            }
        }

        class Account
        {
            private readonly IAccount account;

            public Account(IAccount account)
            {
                this.account = account;
            }
            public void PrintAccount()
            {
                account.PrintDetails();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                IAccount ca = new CurrentAccount();
                Account a = new Account(ca);
                a.PrintAccount();



                IAccount sa = new SavingAccount();
                Account a2 = new Account(sa);
                a2.PrintAccount();

                Console.ReadLine();
            }
        }
    }
}
