using System;

namespace TwoGuys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person joe = new Person(){ Name = "Joe", Cash = 50};
            Person bob = new Person() { Name = "Bob", Cash = 100 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount:");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;

                bool isInt = int.TryParse(howMuch, out int quantity);

                if (isInt)
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if(whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(quantity);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(quantity);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }

                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }

   
}
