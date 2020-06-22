using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _048_Operator_do_while
 * DESC: do~while
-----------------------------------------------------------------------------*/
namespace _048_Operator_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int num;
            int total = 0;

            Console.Write("0부터 몇까지 더할까요?");
            num = int.Parse(Console.ReadLine());

            do
            {
                total = total + a++;
            } while (a <= num);

            Console.WriteLine("total:  {0}", total);
        }
    }
}
