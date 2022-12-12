using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("guess my lucky number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numGuessed = number == 47;

            //While loop
            while (!numGuessed)
            {
                switch (number)
                {
                    case 27:
                        Console.WriteLine("You guessed 27, that's incorrect! Try again!");
                        Console.WriteLine("Guess my lucky number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 99:
                        Console.WriteLine("You guessed 99, that's incorrect! Try again!");
                        Console.WriteLine("Guess my lucky number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 105:
                        Console.WriteLine("You guessed  105, that's incorrect! Try again!");
                        Console.WriteLine("Guess my lucky number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 15:
                        Console.WriteLine("You guessed 15, that's incorrect! Try again!");
                        Console.WriteLine("Guess my lucky number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 47:
                        Console.WriteLine("You guessed 47! That's my lucky number!");
                        numGuessed = true;
                        break;

                    case 2:
                        Console.WriteLine("You guessed 2, that's incorrect! Try again!");
                        Console.WriteLine("Guess my lucky number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                    default:
                        Console.WriteLine("That's incorrect! Try again!");
                        Console.WriteLine("Guess my lucky number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            

            Console.WriteLine("guess the number!");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool numberGuessed = number1 == 99;

            // Do While Loop
            do
            {

                switch (number1)
                {
                    case 18:
                        Console.WriteLine("You guessed 18, that's incorrect! Try again!");
                        Console.WriteLine("Guess the number!");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 45:
                        Console.WriteLine("You guessed 45, that's incorrect! Try again!");
                        Console.WriteLine("Guess the number!");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 85:
                        Console.WriteLine("You guessed 85, that's incorrect! Try again!");
                        Console.WriteLine("Guess the number!");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 34:
                        Console.WriteLine("You guessed 34, that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 99:
                        Console.WriteLine("You guessed 99! That's the number!");
                        numberGuessed = true;
                        break;

                    case 322:
                        Console.WriteLine("You guessed 7, that's incorrect! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;


                    default:
                        Console.WriteLine("That's incorrect! Try again!");
                        Console.WriteLine("Guess the number!");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!numberGuessed);

            Console.Read();        
            

        }        
    }
}
