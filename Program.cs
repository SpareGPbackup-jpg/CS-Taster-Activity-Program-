using System;

namespace FTest_2
{
    internal class Program
    {
        const decimal ValueGBP = 1.0m;
        const decimal ValueEUR = 1.15m;
        const decimal ValueUSD = 1.34m;

        static decimal ConvertCurrency(decimal amount, decimal SourceRate, decimal DestRate)
        {
            return amount / SourceRate * DestRate;
        }
        static decimal ParseInput()
        {
            Console.Write("Please enter the original amount: ");
            string UserString = Console.ReadLine();

            if (decimal.TryParse(UserString, out decimal UserPounds))
            {
                return UserPounds;
            }
            else
            {
                Console.WriteLine("This input is invalid. Try again.");
                return ParseInput();
            }

        }

        static string ExchangeTo()
        {
            string UserString = Console.ReadLine();
            if (UserString == "E")
            {
                return UserString;
            }
            else if (UserString == "D")
            {
                return UserString;
            }
            else if (UserString == "G")
            {
                return UserString;
            }
            else
            {
                Console.WriteLine("This input is invalid. Please try again.");
                return ExchangeTo();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What currency would you like to convert from?" + "\n" + "G: Great British Pound" + "\n" + "E: Euro" + "\n" + "D: Dollar");
            string ConvertFrom = ExchangeTo();
            decimal UserInput = ParseInput();
            Console.WriteLine("What currency would you like to convert to?" + "\n" + "G: Great British Pound" + "\n" + "E: Euro" + "\n" + "D: Dollar");
            string ConvertTo = ExchangeTo();

            decimal Source = 0m;
            decimal Dest = 0m;

            if (ConvertFrom == "E")
            {
                Source = ValueEUR;
            }
            else if (ConvertFrom == "D")
            {
                Source = ValueUSD;
            }
            else
            {
                Source = ValueGBP;
            }

            if (ConvertTo == "E")
            {
                Dest = ValueEUR;
            }
            else if (ConvertTo == "D")
            {
                Dest = ValueUSD;
            }
            else
            {
                Dest = ValueGBP;
            }


            decimal Final = ConvertCurrency(UserInput, Source, Dest);
            Console.WriteLine($"Converted amount: {Math.Round(Final, 2)}");


        }
    }

}
