using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 200612;
            int userPin;
            int balance = 10000000;
            int choice;
            int amount;

            Console.WriteLine("Enter Your Pin Number");
            userPin = Convert.ToInt32(Console.ReadLine());

            if (pin == userPin)
            {
                while (true)
                {
                    Console.WriteLine("*Welcome to ATM Service*");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Withdraw Cash");
                    Console.WriteLine("3. Deposit Cash");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine("*");
                    Console.WriteLine("Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(" YOUR BALANCE IN Rs : " + balance);
                            break;
                        case 2:
                            Console.WriteLine(" ENTER THE AMOUNT TO WITHDRAW: ");
                            amount = Convert.ToInt32(Console.ReadLine());
                            if (amount % 100 != 0)
                            {
                                Console.WriteLine(" PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                            }
                            else if (amount > (balance - 500))
                            {
                                Console.WriteLine(" INSUFFICIENT BALANCE");
                            }
                            else
                            {
                                balance = balance - amount;
                                Console.WriteLine(" PLEASE COLLECT CASH");
                                Console.WriteLine(" YOUR CURRENT BALANCE IS " + balance);
                            }
                            break;
                        case 3:
                            Console.WriteLine(" ENTER THE AMOUNT TO DEPOSIT: ");
                            amount = Convert.ToInt32(Console.ReadLine());
                            balance = balance + amount;
                            Console.WriteLine(" YOUR BALANCE IS " + balance);
                            break;
                        case 4:
                            Console.WriteLine(" THANK U USING ATM");
                            return;
                        default:
                            Console.WriteLine(" INVALID SELECTION, TRY AGAIN");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine(" INVALID PIN, TRY AGAIN");
            }
        }
    }
}