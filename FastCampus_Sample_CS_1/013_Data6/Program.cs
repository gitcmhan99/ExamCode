using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _013_Data6
 * DESC: 소수점 데이터형의 기초, 리터럴 접미사(f(F), m(M))
-----------------------------------------------------------------------------*/
namespace _013_Data6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3.1415926535897932384626433832f;
            Console.WriteLine("a: {0}", a);

            double b = 3.1415926535897932384626433832;
            Console.WriteLine("b: {0}", b);

            decimal c = 3.1415926535897932384626433832m;
            Console.WriteLine("c: {0}", c);
        }
    }
}
