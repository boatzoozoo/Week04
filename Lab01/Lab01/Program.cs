using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, s;
            double id,gpa;
            Console.Write("Name : ");
            n = Console.ReadLine().ToString().ToUpper();
            Console.Write("Last Name : ");
            s = Console.ReadLine().ToString().ToUpper();
            Console.Write("ID : ");
            id = double.Parse(Console.ReadLine());
            Console.Write("GPA : ");
            gpa = double.Parse(Console.ReadLine());
            
        }
    }
}
