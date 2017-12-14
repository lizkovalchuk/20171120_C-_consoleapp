using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171130ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string GreetingMessage = "Welcome to Mad Libs";
            Console.WriteLine(GreetingMessage);

            Console.WriteLine("Enter your least favorite adjective");
            string userAdjective = Console.ReadLine();
            Console.WriteLine("You entered " + userAdjective);

            Console.WriteLine("Enter color");
            string userColor = Console.ReadLine();
            Console.WriteLine("You entered " + userColor);

            Console.WriteLine("Enter an interger between 1 and 10");
            int userNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You entered " + userNumber);

            Console.WriteLine("Are you pregnant?");
            bool userBool = false;
            string anwser;
            anwser = Console.ReadLine().ToLower();
            anwser.Trim();

            if (anwser == "yes")
            {
                userBool = true;
            }

            Console.Write("It was a " + userAdjective + " evening with " + userNumber + " bright " +
                userColor + " patches shinning furiously. I knew that it was a sign that my love was " +
                userBool);
       
            Console.ReadKey();         
        }
    }
}
