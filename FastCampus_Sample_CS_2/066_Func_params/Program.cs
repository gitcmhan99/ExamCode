using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _066_Func_params
 * DESC: 파라미터 제한 없이 처리
-----------------------------------------------------------------------------*/
namespace _066_Func_params
{
    class Program
    {
        static int Total(params int[] values)
        {
            int total = 0;

            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }
            return total;
        }

        static void CheckValues(params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Value: {0}   {1}", values[i], values[i].GetType() );
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Total: " + Total(200, 5, 3, 1, 100));
            Console.WriteLine("Total: " + Total(1, 2, 3, 4, 5));
            Console.WriteLine("Total: " + Total(10, 1000));

            CheckValues(0, 10.2f, 10.4, 10434839840d, "Hello World!");
        }
    }
}
