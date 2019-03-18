/******************************************************************************

Guess the number

*******************************************************************************/
using System;
class Program
{

    public static int GuessTheNumber(int a, int b)
    {
        Random random = new Random();
        int steps = 0;
        int secretNumber = random.Next(a, b);
        Console.WriteLine("\n Secret number is: " + secretNumber);

        bool notFound = true;

        int letItBe;
        while (notFound)
        {
            letItBe = (a + b) / 2;
            if (letItBe == secretNumber)
            { notFound = false; }

            if (secretNumber > letItBe)
            { a = letItBe; }
            else
            { b = letItBe; }
            steps++;
        } // while
        return steps;
    } // the end of GuessTheNumber


    static void Main()
    {

        int a = 0; int b = 400;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 800;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 1200;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 1600;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 2000;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        //Console.WriteLine(Math.Pow(2,10));
        




        Console.ReadKey();

    }

}