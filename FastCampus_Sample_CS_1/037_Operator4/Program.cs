using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _037_Operator4
 * DESC: 관계 연산자, 피연산자의 비교(bool)
 * ‘<‘, ‘>’, ‘<=‘, ‘>=‘, ‘==‘, ‘!=‘
-----------------------------------------------------------------------------*/
namespace _037_Operator4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int a = 100;
            int b = 1000;

            result = (a == b);
            Console.WriteLine("(a == b): {0}", result);

            result = (a != b);
            Console.WriteLine("(a != b): {0}", result);

            result = (a > b);
            Console.WriteLine("(a > b): {0}", result);

            result = (a < b);
            Console.WriteLine("(a < b): {0}", result);

            result = (a >= b);
            Console.WriteLine("(a >= b): {0}", result);

            result = (a <= b);
            Console.WriteLine("(a <= b): {0}", result);
        }
    }
}
