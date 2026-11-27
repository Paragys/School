using System;

namespace IT118Project
{
    // Safe input methods. They keep asking until the user types something valid,
    // so bad input can never crash the program. Read how they work, then use them.
    internal static class InputHelper
    {
        public static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string line = Console.ReadLine();

                if (int.TryParse(line, out int value) && value >= min && value <= max)
                {
                    return value;
                }

                Console.WriteLine("Please enter a whole number from " + min + " to " + max + ".");
            }
        }

        public static decimal ReadDecimal(string prompt, decimal min, decimal max)
        {
            while (true)
            {
                Console.Write(prompt);
                string line = Console.ReadLine();

                if (decimal.TryParse(line, out decimal value) && value >= min && value <= max)
                {
                    return value;
                }

                Console.WriteLine("Please enter a number from " + min + " to " + max + ".");
            }
        }

        public static string ReadText(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string line = Console.ReadLine();

                if (line != null && line.Trim().Length > 0)
                {
                    return line.Trim();
                }

                Console.WriteLine("This cannot be empty.");
            }
        }
    }
}
