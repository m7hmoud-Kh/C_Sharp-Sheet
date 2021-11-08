using System;

namespace sheet_Ch4
{
    class Program
    {
        static void Main(string[] args)
        {

            //question 4.9
            /*
            Account Account1 = new Account("mahmoud",50.0);
            Account Account2 = new Account("khairy",7.53);

            Console.WriteLine($"{Account1.Name}'s Balance is {Account1.Balance:C}");
            Console.WriteLine($"{Account2.Name}'s Balance is {Account2.Balance:C}");

            Console.WriteLine("Enter Deposite For Acccount1");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            Account1.Deposite(depositAmount);

            Console.WriteLine("Enter Deposite For Acccount2");
            double depositAmount2 = Convert.ToDouble(Console.ReadLine());
            Account2.Deposite(depositAmount2);

            Console.WriteLine($"{Account1.Name}'s Balance is {Account1.Balance:C}");
            Console.WriteLine($"{Account2.Name}'s Balance is {Account2.Balance:C}");

            Console.WriteLine("Enter Withdraw For Acccount1");
            double Withdraw = Convert.ToDouble(Console.ReadLine());
            Account1.Withdraw(Withdraw);

            Console.WriteLine("Enter Withdraw For Acccount2");
            double Withdraw2 = Convert.ToDouble(Console.ReadLine());
            Account2.Withdraw(Withdraw2);

            
            Console.WriteLine($"{Account1.Name}'s Balance is {Account1.Balance:C}");
            Console.WriteLine($"{Account2.Name}'s Balance is {Account2.Balance:C}");
            */

            // question 4.10
            /*
            Student student1 = new Student("mah123", "mahmoud khariy", 10, 20, -5);
            Console.WriteLine($"{student1.Name}'s Grade {student1.GetPercentage()}%");
            */

            // question 4.11
            /*
            Asset Asset1 = new Asset("mahmoud",150,3.5);
            Asset Asset2 = new Asset("khairy", 100, 7.4);

            Console.WriteLine($"Aseet name : {Asset1.Name} And the value {Asset1.Value} And Depreciation {Asset1.Depreciation}");
            Console.WriteLine($"Aseet name : {Asset2.Name} And the value {Asset2.Value} And Depreciation {Asset2.Depreciation}");

            Asset1.Value += 5;
            Asset2.Value += 10;

            Console.WriteLine($"Aseet name : {Asset1.Name} And the value {Asset1.Value} And Depreciation {Asset1.Depreciation}");
            Console.WriteLine($"Aseet name : {Asset2.Name} And the value {Asset2.Value} And Depreciation {Asset2.Depreciation}");
            */

            //question 4.12
            /*
            Coaching coaching = new Coaching("Coaching",11,"Eveing",300.4);
            coaching.DisplayDetails();
            */

            //4.13
            /*
            Account Account1 = new Account("mahmoud", 50.0);
            Account Account2 = new Account("khairy", 7.53);

            DisplayAccount(Account1);
            DisplayAccount(Account2);

            Console.WriteLine("Enter Deposite For Acccount1");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            Account1.Deposite(depositAmount);

            Console.WriteLine("Enter Deposite For Acccount2");
            double depositAmount2 = Convert.ToDouble(Console.ReadLine());
            Account2.Deposite(depositAmount2);

            DisplayAccount(Account1);
            DisplayAccount(Account2);

            Console.WriteLine("Enter Withdraw For Acccount1");
            double Withdraw = Convert.ToDouble(Console.ReadLine());
            Account1.Withdraw(Withdraw);

            Console.WriteLine("Enter Withdraw For Acccount2");
            double Withdraw2 = Convert.ToDouble(Console.ReadLine());
            Account2.Withdraw(Withdraw2);

            DisplayAccount(Account1);
            DisplayAccount(Account2);
            */

        }
        /*
        static void DisplayAccount(Account accountToDisplay)
        {
            Console.WriteLine($"{accountToDisplay.Name}'s Balance is {accountToDisplay.Balance:C}");
        }
        */
    }
}
