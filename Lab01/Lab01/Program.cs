using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)

        {
            int a, b, x, y,Sum1,Sum2,Sum3,Sum4,Sum5,Sum6,Sum7,Sum8,Sum9,Sum10;
            a = 10; b = 20;
            x = 5 ; y = 2;
            Sum1=a + b ;
            Console.WriteLine(" sum 1 a+b={0} ",Sum1);
            Sum2 = x - b;    
            Console.WriteLine(" sum 2 x-b={0} ",Sum2);
            Sum3 = x * b;
            Console.WriteLine(" sum 3 x*b={0} ",Sum3);
            Sum4 = y / a;
            Console.WriteLine(" sum 4 y/a={0} ",Sum4);
            Sum5 = b % y;
            Console.WriteLine(" sum 5 b%y={0} ",Sum5);
            Sum6 = y + 10 % x;
            Console.WriteLine(" sum 6 y+10%x={0} ", Sum6);
            Sum7 = a / 3 * 5;
            Console.WriteLine(" sum 7 a/3*5={0} ", Sum7);
            Sum8 = 9 / 2 * a;
            Console.WriteLine(" sum 8 9/2*a={0} ",Sum8);
            Sum9 = y % 8;
            Console.WriteLine(" sum 9 y%8={0} ",Sum9);
            Sum10 = 100 * x + y % 2 - a;
            Console.WriteLine(" sum 10 100*x+y%2-a={0} ",Sum10);
            
        }
        }


    }

