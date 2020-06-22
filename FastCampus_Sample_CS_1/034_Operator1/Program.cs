using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _034_Operator1
 * DESC: 산술 연산자, +,  -,  *,  /,  %, (모든 수치 데이터 형태)
-----------------------------------------------------------------------------*/
namespace _034_Operator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("c: " + c);

            Console.WriteLine("100 - 10 = " + (100 - 10));

            int d = a / b;
            Console.WriteLine("d: " + d);

            int e = a * (b + c);
            Console.WriteLine("e: " + e);

            int f = (a + b) % 2;
            Console.WriteLine("f: " + f);
        }
    }
}
