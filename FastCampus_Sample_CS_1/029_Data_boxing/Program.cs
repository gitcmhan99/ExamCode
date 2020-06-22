using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _028_Data_Reference
 * DESC: boxing, unboxing기초(boxing하는 과정에서 heap영역에 메모리가 할당)
-----------------------------------------------------------------------------*/
namespace _029_Data_boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;   //boxing
            int j = (int)o; //unboxing
            i = 456;

            Console.WriteLine("i: {0},  o: {1},  j: {2}", i, o, j);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(i, o));
        }
    }
}
