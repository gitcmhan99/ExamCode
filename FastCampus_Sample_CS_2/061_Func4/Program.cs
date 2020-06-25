using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _061_Func4
 * DESC: 함수 기초: 리턴형 O, 파라미터 O(2개 이상의 파라미터)
-----------------------------------------------------------------------------*/
namespace _061_Func4
{
    class Program
    {
        static bool PrintDot(int x, int y)
        {
            Console.WriteLine();

            if (x <= 0 || y <= 0)
                return false;

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write("#");
                }
            }

            return true;
        }

        static int Total(int kor, int eng, int math)
        {
            int total = 0;
            total = kor + eng + math;
            return total;
        }

        static void Main(string[] args)
        {
            int total = 0;

            if(false == PrintDot(5, 7))
            {
                Console.WriteLine("PrintDot return False");
            }
            if (false == PrintDot(0, 7))
            {
                Console.WriteLine("PrintDot return False");
            }

            total = Total(80, 90, 100);
            Console.WriteLine("total=== {0}", total);
        }
    }
}
