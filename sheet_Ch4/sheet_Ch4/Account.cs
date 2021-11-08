using System;
using System.Collections.Generic;
using System.Text;

namespace sheet_Ch4
{
    class Account
    {
        public string Name;
        private double balance;
  

        public Account(string name,double initBalance)
        {
            Name = name;
            Balance = initBalance;
        }

        public double Balance
        {
            private set
            {
                if (value > 0)
                    balance = value;
            }

            get
            {
                return balance;
            }
        }


        public void Deposite(double depositAmount)
        {
            if (depositAmount > 0)
                Balance += depositAmount;
        }

        public void Withdraw(double money)
        {
            if (money <= Balance)
                Balance -= money;
            else
                Console.WriteLine("Withdrawal amount exceeded account balance.");
        }


    }
}
