using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _021_Data_nullable
 * DESC: nullable데이터형 활용
-----------------------------------------------------------------------------*/
namespace _021_Data_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? a = 3.14;
            char? b = 'a';

            int num = 10;
            int? c = num;

            bool? isFlag = null;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);

            Console.WriteLine("isFlag: {0}", isFlag);
            Console.WriteLine("isFlag HasValue: {0}", isFlag.HasValue);

            if (isFlag.HasValue) //값을 참조하려면 반드시 null인지 체크..
                Console.WriteLine("isFlag HasValue: {0}", isFlag.Value);
        }
    }
}
