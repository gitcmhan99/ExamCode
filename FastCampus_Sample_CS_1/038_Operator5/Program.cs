using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _038_Operator5
 * DESC: 관계 연산자, 
 * 조건부 논리(‘&&’, ‘||’)
 * 논리 부정 연산자 (‘!’)
-----------------------------------------------------------------------------*/
namespace _038_Operator5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int a = 100;
            int b = 1000;

            result = (a == 100) && (b == 1000); //true , true
            Console.WriteLine("(a == 100) && (b == 1000): {0}", result);

            result = (a == 100) || (b == 1000); //true , true
            Console.WriteLine("(a == 100) || (b == 1000): {0}", result);

            result = (a == 100) && (b == 100); //true , false
            Console.WriteLine("(a == 100) && (b == 100): {0}", result);

            result = (a == 100) || (b == 100); //true , false
            Console.WriteLine("(a == 100) || (b == 100): {0}", result);

            result = false;
            result = !result;
            Console.WriteLine("!result: {0}", result);
            result = !result;
            Console.WriteLine("!result: {0}", result);
        }
    }
}
