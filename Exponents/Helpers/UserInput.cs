using Exponents.Models;


namespace Exponents.Helpers
{
    public class UserInput
    {
        public void GetUserPreferences(User user)
        {
            int validNumber;

            bool redoLoop = true;

            while (redoLoop)
            {
                Console.WriteLine("Enter a whole number:");

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   validNumber <= 0 ||
                   validNumber > 1290)
                {
                    Console.WriteLine("Enter a valid whole number between 1 and 1290.");
                    redoLoop = true;
                    Console.WriteLine();
                }

                else
                {
                    user.inputtedNumber = validNumber;
                    redoLoop = false;
                }

            }

            GetAlignment(user);

        }

        public void GetAlignment(User user)
        {
            string? validAlignment;

            bool redoLoop = true;

            while (redoLoop)
            {
                Console.WriteLine("How would you like your numbers aligned? Right / Left");

                validAlignment = Console.ReadLine().ToLower();

                if (!string.IsNullOrEmpty(validAlignment))
                {
                    if (validAlignment.CompareTo("left") != 0 &&
                        validAlignment.CompareTo("right") != 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter a valid alignment. Left or Right");
                        redoLoop = true;
                    }
                    else
                    {
                        user.alignment = validAlignment;
                        redoLoop = false;
                    }
                }

                else
                {
                    Console.WriteLine("Enter a valid alignment. Left or Right");
                    redoLoop = true;
                }

            }

        }

        public bool ContinueAnalyzer(User user)
        {
            char validAnswer;

            bool redoLoop = true;
            bool continueExponent = false;

            while (redoLoop)
            {
                Console.WriteLine("Do you wish to continue? y/n");

                if (!char.TryParse(Console.ReadLine().ToLower(), out validAnswer) ||
                   validAnswer.CompareTo('y') != 0 &&
                   validAnswer.CompareTo('n') != 0)
                {
                    Console.WriteLine("Enter y or n only.");
                    redoLoop = true;
                }

                else
                {
                    if (validAnswer.CompareTo('y') == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose to continue with another number.");
                        Console.WriteLine();
                        continueExponent = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Have a nice day. Goodbye.");
                        continueExponent = false;
                    }

                    redoLoop = false;
                }

            }

            return continueExponent;

        }

    }

}
