using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _047_Operator_while
 * DESC: while기초
-----------------------------------------------------------------------------*/
namespace _047_Operator_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int total = 0;
            int total2 = 0;

            while(a <= 10 || b <= 10)
            {
                total = total + a++; //1~10
                total2 = total + ++b; //1~11
            }

            Console.WriteLine("total:  {0}", total);
            Console.Write("total2:  {0}", total2);
        }
    }
}
