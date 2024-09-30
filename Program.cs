using System;




    internal class Program
    {
        static void Main()
        {
            int TotalCoffeeCost =0;

            Start:
            Console.WriteLine("Please Select your coffee size : 1 - Small(Rs10), 2 - Medium(Rs20), 3 - Large(Rs30)");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 10;
                    break;
                case 2:
                    TotalCoffeeCost += 20;
                    break;
                case 3:
                    TotalCoffeeCost += 30;
                    break;
                default:

                    Console.WriteLine("Your choice {0} is invalid ", UserChoice);
                    break;
            }
         Decide:
        Console.WriteLine("Do you want to buy another coffee - Yes or No");
        string UserDecision = Console.ReadLine();

        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid ", UserDecision);
                goto Decide;
        }
        Console.WriteLine("Thank you for shopping with us :)");
        Console.WriteLine("Bill Amount =Rs{0} ", TotalCoffeeCost);


        }
    }

