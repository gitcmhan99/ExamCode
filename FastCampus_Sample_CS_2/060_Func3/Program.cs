using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _060_Func3
 * DESC: 함수 기초: 리턴형 O, 파라미터 O(1개의 파라미터)
-----------------------------------------------------------------------------*/
namespace _060_Func3
{
    class Program
    {
        static int Square(int i)
        {
            int input = i;
            return input * input;
        }

        static void Main(string[] args)
        {
            int a = 2;
            int resultA = Square(a);
            Console.WriteLine("resultA: " + resultA);

            int b = 4;
            int resultB = Square(b);
            Console.WriteLine("resultB: " + resultB);

            int resultC = Square(6);
            Console.WriteLine("resultC: " + resultC);

            resultC = Square(resultA * 3);
            Console.WriteLine("resultC: " + resultC);
        }
    }
}


