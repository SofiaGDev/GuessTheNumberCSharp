using System;

namespace Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            bool check=false;
            int maxnum = 0;
            int guess = 0;
            Console.WriteLine("Choose the size of the game");
            maxnum = int.Parse(Console.ReadLine());

            Random dice = new Random();
            int number = dice.Next(1, maxnum);

            //Console.WriteLine(number);

            while (check == false) {

                Console.WriteLine("---------------------------------------\nGuess the number between 1 and " + maxnum + "\n");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > maxnum || guess < 1)
                {
                    Console.WriteLine("This number is out of boundries");
                }
                if (guess > number)
                {

                    Console.WriteLine("your guess is too high\n");
                }
                if (guess < number)
                {

                    Console.WriteLine("your guess is too low\n");
                }
                if (guess == number)
                {

                    Console.WriteLine("\n----------------------------------\nCONGRATULATIONS\nthe number is " + number);
                    check = true;
                    Console.ReadKey();

                }
            }

        }
    }
}