using Exponents.Helpers;
using Exponents.Models;

bool continueAnalyzer = true;

User user = new User();
UserInput userInput = new UserInput();
Message message = new Message();

while (continueAnalyzer)
{
    userInput.GetUserPreferences(user);

    Console.WriteLine();

    message.GetTable(user);

    Console.WriteLine();

    continueAnalyzer = userInput.ContinueAnalyzer(user);

}