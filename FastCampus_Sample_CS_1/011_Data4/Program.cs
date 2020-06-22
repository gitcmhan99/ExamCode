using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _011_Data4
 * DESC: 2진수 리터럴 접두사0b(0B), 16진수 리터럴 접두사0x(0X)
-----------------------------------------------------------------------------*/
namespace _011_Data4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0b11111111; //2진수 리터럴 접두사0b(0B)
            int b = 0xFF;       //16진수 리터럴 접두사0x(0X)

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: " + b);
        }
    }
}
