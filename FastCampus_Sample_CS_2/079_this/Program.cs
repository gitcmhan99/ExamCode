using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _079_this
 * DESC: this키워드: 객체 자신을 참조하는 키워드
-----------------------------------------------------------------------------*/
namespace _079_this
{
    class AA
    {
        int a;

        public AA(int a) {
            this.a = a;
        }

        public void Print() {
            Console.WriteLine("a: {0}", a);
        }
    }

    class Program
    {
        static void Main(string[] args) {

            AA aa = new AA(10);
            aa.Print();
        }
    }
}
