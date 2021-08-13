using System;

namespace Exercise_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";
            string userInput;
            int consonantNum;
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };


            while (repeat == "y")
            {
                Console.WriteLine("Enter some text.");
                userInput = Console.ReadLine().ToLower();
                consonantNum = 0;

                foreach (char c in userInput)
                {
                    switch (c)
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'f':
                        case 'g':
                        case 'h':
                        case 'j':
                        case 'k':
                        case 'l':
                        case 'm':
                        case 'n':
                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                        case 't':
                        case 'v':
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                            consonantNum++;
                            break;
                        default: continue;
                    }
                }
                Console.WriteLine("Your total number of consonants is: " + consonantNum);

                Console.WriteLine("Would you like to continue? (y/n)");
                repeat = Console.ReadLine().ToLower();

                
            }

            Console.WriteLine("Thank you for using our software. Goodbye");
        }
    }
}
