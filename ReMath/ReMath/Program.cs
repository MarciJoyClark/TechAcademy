using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReMath
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me a positive, whole number to run some math on.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your input was " + userInput + ".");
            int variable = Math_fnc.AddFirst(userInput);
            Console.WriteLine("Your number plus 13 = " + variable);
            Console.ReadLine();
            Console.WriteLine("Give me another positive, whole number to run some more math on.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your input was " + userInput2 + ".");
            int variable2 = Math_fnc.Subtract(userInput2);
            Console.WriteLine("Your number - 4 = " + variable2);
            Console.ReadLine();
            Console.WriteLine("How abouts OOOONE more?");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your input was " + userInput3 + ".");
            int variable3 = Math_fnc.AddSecond(userInput3);
            Console.WriteLine("Your number plus 9 = " + variable3);
            Console.ReadLine();
        }
    }
}

