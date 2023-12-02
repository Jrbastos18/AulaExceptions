using System.Globalization;
using Aula155ExFixExceptions.Entities.Exceptions;

namespace Aula155ExFixExceptions.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        //Construtores
        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        //Métodos
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("not enough balance");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}
