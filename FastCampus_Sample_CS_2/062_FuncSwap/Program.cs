using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _062_FuncSwap
 * DESC: 함수 기초: 리턴형 O, 파라미터 O(2개 이상의 파라미터)
-----------------------------------------------------------------------------*/
namespace _062_FuncSwap
{
    class Program
    {
        static public void ValueSwap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("ValueSwap");
            Console.WriteLine("num1: {0}    num2: {1}", a, b);
        }

        static public void RefSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("RefSwap");
            Console.WriteLine("num1: {0}    num2: {1}", a, b);
        }
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = -100;

            ValueSwap(num1, num2);
            Console.WriteLine("num1: {0}   num2: {1}", num1, num2);

            RefSwap(ref num1, ref num2);
            Console.WriteLine("num1: {0}   num2: {1}", num1, num2);
        }
    }
}
