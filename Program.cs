using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultDelegate
{
    //delegate long Sum(int x, int y);
    //delegate void Print(int result, string title);
    //delegate bool IsNotZero(long value);

    class Program
    {
        static void Main(string[] args)
        {
            Do(PrintResult, SumValues, NotZero, 5, 10);


            Action<long, string> printAction = PrintResult;
            printAction.Invoke(20, "VALUE");

            Func<int, int, long> sumFunc = SumValues;
            long result2 = sumFunc.Invoke(10, 20);

            Predicate<long> predicateIsZero = NotZero;
            bool result0 = predicateIsZero.Invoke(10);

            Func<long, bool> funcIsZero = NotZero;
        }

        static void Do(Action<long, string> print, Func<int, int, long> sum, Predicate<long> notZero, int a, int b)
        {
            long result = sum.Invoke(a, b);
            bool isZero = notZero.Invoke(result);
            if(isZero)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                print.Invoke(result, "RESULT");
            }
        }

        static void PrintResult(long result, string title)
        {
            Console.WriteLine($"{title} = {result}");
        }

        static long SumValues(int x, int y)
        {
            return x + y;
        }

        static bool NotZero(long value)
        {
            return value == 0;
        }

    }
}
