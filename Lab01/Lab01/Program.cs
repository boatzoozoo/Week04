using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Random random = new Random();
            int randomnumber = random.Next(0, 9);
            Console.Write("Enter Number : ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(randomnumber);
            bool re = randomnumber == N;
            Console.WriteLine("{0}",re);
        }
    }
}
