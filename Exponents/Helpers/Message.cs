using Exponents.Helpers;
using Exponents.Models;
using System.ComponentModel.Design;

namespace Exponents.Helpers
{
    public class Message
    {
        public void GetTable(User user)
        {            
            Console.WriteLine(String.Format("{0,-10} {1,-20} {2, -20}", "Number", "Squared", "Cubed"));
            Console.WriteLine(GetDivider());

            for (int i = 1; i <= user.inputtedNumber; i++)
            {
                Console.WriteLine(GetCalculations(i, user));
            }

        }

        private static string GetDivider() => String.Format("{0,10} {1,20} {2, 20}", "==========", 
                                                                                     "====================", 
                                                                                     "====================");

        private string GetCalculations(int number, User user)
        {
            Calculations calculations = new Calculations();
            if (user.alignment == "left")
            {
                return String.Format("{0,-10} {1,-20} {2, -20}", number,
                                     calculations.GetSquared(number).ToString(),
                                     calculations.GetCubed(number).ToString());
            }
            else
            {
                return String.Format("{0,10} {1,20} {2, 20}", number,
                                     calculations.GetSquared(number).ToString(),
                                     calculations.GetCubed(number).ToString());
            }
        }

    }
}
