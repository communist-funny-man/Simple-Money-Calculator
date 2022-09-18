using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How much money do you have");
            string numerodemonedas = Console.ReadLine();
            int moneynum = int.Parse(numerodemonedas);

            int after500 = (moneynum / 500);
            int resto500 = (moneynum % 500);
            int after100 = (resto500 / 100);
            int resto100 = (resto500 % 100);
            int after25 = (resto100 / 25);
            int resto25 = (resto100 % 25);
            int after10 = (resto25 / 10);
            int resto10 = (resto25 % 10);
            int after5 = (resto10 / 5);
            int resto5 = (resto10 % 5);
            int after1 = (resto100 / 1);
            


            Console.WriteLine(after500 + " 500 $ coins");
            Console.WriteLine(after100 + " 100 $ coins");
            Console.WriteLine(after25 + " 25$ coins");
            Console.WriteLine(after10 + " 10$ coins");
            Console.WriteLine(after5 + " 5$ coins");
            Console.WriteLine(after1 + " 1$ coins");

            Console.ReadKey();


        }
    }
}
