using System;

namespace LabAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Please Choose your bank A, B, or C");
            string choice = Console.ReadLine().ToUpper();
            switch(choice){
                case "A":
                Console.WriteLine("Thank you for choosing bank A");
                BankA balanceA = new BankA();
                balanceA.getBalance();
                break;
                case "B":
                Console.WriteLine("Thank you for choosing bank B");
                BankB balanceB = new BankB();
                balanceB.getBalance();
                break;
                case "C":
                Console.WriteLine("Thank you for choosing bank C");
                BankC balanceC = new BankC();
                 balanceC.getBalance();
                break;
                default:
                Console.WriteLine("Please choose between banks A, B, or C");
                Console.ReadLine().ToUpper();
                break;
            }
            
            // if (choice == "A")
            // {
            //     Console.WriteLine("Thank you for choosing bank A");
            //     BankA balanceA = new BankA();
            //     balanceA.getBalance();
            // }else if(choice == "B")
            // {
            //     Console.WriteLine("Thank you for choosing bank B");
            //     BankB balanceB = new BankB();
            //     balanceB.getBalance();
            // }
            // else
            // {
            //     Console.WriteLine("Thank you for choosing bank C");
            //     BankC balanceC = new BankC();
            //      balanceC.getBalance();
            // }
            }    
            
    }
}
