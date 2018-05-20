using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Math_fnc
    {
            public Math_fnc()
            {          
                try
                {
                    Console.WriteLine("Pick a positive whole number.");
                    int numberOne = Convert.ToInt32(Console.ReadLine());
                        int numberAdd = numberOne + 13;                
                    Console.WriteLine("That number + 13 is " + numberAdd +  ". Pick a higher number!");
                    int numberTwo = Convert.ToInt32(Console.ReadLine());
                        int numberSub = numberTwo - numberOne;
                    Console.WriteLine("Your new number minus the first one you gave me is " +numberSub+ "!");
                    int numberThree = numberSub + numberAdd;
                    Console.WriteLine(numberSub + " Plus " + numberAdd + " is " + numberThree + ". Pretty cool, huh? Now high five your computer for being so smart!");

                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer for me to use.");
                    return;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Don't give me a \"0\", please!");
                }
                catch (Exception)
                {
                    Console.WriteLine("You messed something up! Try again!");
                }
                finally
                {
                    Console.ReadLine();
                }
            }
    }
}
