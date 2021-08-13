using System;

namespace Exercises_26_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";
            string userInput;
            int vowelNum;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };


            while (repeat == "y")
            {
                Console.WriteLine("Enter some text.");
                userInput = Console.ReadLine().ToLower();
                vowelNum = 0;

                foreach (char c in userInput)
                {
                    switch (c)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            vowelNum++;
                            break;
                        default: continue;
                    }
                }
                Console.WriteLine("Your total number of vowels is: " + vowelNum);

                Console.WriteLine("Would you like to continue? (y/n)");
                repeat = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Thank you for using our software. Goodbye");


        }
    }
}
