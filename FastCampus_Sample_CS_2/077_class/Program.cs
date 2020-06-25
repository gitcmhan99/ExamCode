using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _077_class
 * DESC: 클래스 기본
-----------------------------------------------------------------------------*/
namespace _077_class
{
    class AA
    {
        //멤버 변수..
        int num1;
        public int num2, num3;

        //멤버 함수..
        public void Print() {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }
    }

    class Program
    {
        static void Main(string[] args) {
            AA aa = new AA();
            aa.Print();
        }
    }
}
