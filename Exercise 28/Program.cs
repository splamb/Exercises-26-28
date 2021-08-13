using System;

namespace Exercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";
            
            while (repeat == "y")
            {
                Console.WriteLine("Enter some text.");
                string userInput = Console.ReadLine();

                string noVowelOutput = userInput.Replace("a", string.Empty)
                                                .Replace("A", string.Empty)
                                                .Replace("e", string.Empty)
                                                .Replace("E", string.Empty)
                                                .Replace("i", string.Empty)
                                                .Replace("I", string.Empty)
                                                .Replace("o", string.Empty)
                                                .Replace("O", string.Empty)
                                                .Replace("u", string.Empty)
                                                .Replace("U", string.Empty);

                Console.WriteLine(noVowelOutput + "\nWould you like to continue? (y/n)");
                repeat = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Thank you for using our software! Goodbye");
        }
    }
}
