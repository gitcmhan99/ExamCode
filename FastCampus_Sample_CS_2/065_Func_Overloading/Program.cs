using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _065_Func_Overloading
 * DESC: 디폴트 매개 변수(default parameter)
 * 메소드 이름이 중복
 * 파라미터의 형식 다르게
 * 파라미터의 수 다르게
-----------------------------------------------------------------------------*/
namespace _065_Func_Overloading
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Add(double a, double b)
        {
            return a + b;

        }

        //Add(int a, int b, int c) 모호성으로 오류 발생
        static int Add(int a, int b, int c, int d = 0) 
        {
            return (a + b + c + d) * 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Add(int a, int b): " + Add(10, 100));
            Console.WriteLine("Add(int a, int b, int c): " + Add(10, 100, 1000));
            Console.WriteLine("Add(double a, double b): " + Add(10.3, 100.5));
        }
    }
}
