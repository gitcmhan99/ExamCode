using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _078_Constructor
 * DESC: 클래스 생성자, 소멸자
-----------------------------------------------------------------------------*/
namespace _078_Constructor
{
    class AA
    {
        int a;

        public AA() {
            a = 0;

            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}", a);
        }

        ~AA() {
            Console.WriteLine("  Call Destructor  ");
        }
    }
    class Program
    {
        static void Main(string[] args) {
            AA aa = new AA();
        }
    }
}
