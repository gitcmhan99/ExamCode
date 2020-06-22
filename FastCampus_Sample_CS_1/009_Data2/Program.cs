using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _009_Data2
 * DESC: 정수 데이터형의 최소 최대값..
-----------------------------------------------------------------------------*/
namespace _009_Data2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("short min: {0} ~ short max: {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("byte min: {0} ~ byte max: {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("int min: {0} ~ int max: {1}", int.MinValue, int.MaxValue);
        }
    }
}
