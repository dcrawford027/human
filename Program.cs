using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human dustin = new Human("Dustin");
            Human mike = new Human("Mike");

            dustin.Attack(mike);
            Console.WriteLine(mike.Health);
        }
    }
}
