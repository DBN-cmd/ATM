using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Let's build a program that generates an ATM machine. There will be a menu that has three
//options:
//Withdraw
//Deposit
//Balance check
namespace ATMmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int pinNumber;
            int customer1Pin = 1234;
            int ledgerBalance = 0;
            int deposit;
            int withdraw;

            Console.WriteLine("Please enter your pin Number: ");
            pinNumber = Convert.ToInt32(Console.ReadLine());

            if (pinNumber == customer1Pin)
            {
                Console.WriteLine("Pin Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect Pin!");
                return;
            }




            int quitOut = 1;

            while (quitOut > 0)
            {
                Console.WriteLine("*********Welcome to MWS Banking**************\n\n1. Check Balance\n\n2. Withdraw Cash\n\n3. Deposite Cash\n\n4. Quit\n\n*********************************************");
                Console.WriteLine("\n\nPlease enter your choice:\n");
                int custChoice = Convert.ToInt32(Console.ReadLine());

                switch (custChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Your balance is: {ledgerBalance}\n\n");
                        quitOut++;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please enter the amount you wish to withdraw:\n");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        ledgerBalance = ledgerBalance - withdraw;
                        Console.WriteLine($"Your new balance is: {ledgerBalance}\n\n");
                        quitOut++;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Please enter the amount you wish to deposit:\n");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        ledgerBalance = ledgerBalance + deposit;
                        Console.WriteLine($"Your new balance is: {ledgerBalance}\n\n");
                        quitOut++;
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Thank you for using MWS Banking");
                        quitOut = 0;
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter one of the options.\n\n");
                        quitOut++;
                        break;
                }

            }


        }
    }
}