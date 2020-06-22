using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _035_Operator2
 * DESC: 산술 연산자, +,  -,  *,  /,  %, (모든 수치 데이터 형태)
-----------------------------------------------------------------------------*/
namespace _035_Operator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            float c = 123.45f, d = 3.1456f;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);
            Console.WriteLine("d: {0}", d);


            Console.WriteLine("\n정수의 계산");
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a % b = {0}", a % b);

            Console.WriteLine("\n실수의 계산");
            Console.WriteLine("c + d = {0}", c + d);
            Console.WriteLine("c - d = {0}", c - d);
            Console.WriteLine("c * d = {0}", c * d);
            Console.WriteLine("c / d = {0}", c / d);
            Console.WriteLine("c % d = {0}", c % d);
        }
    }
}
