using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _091_Property02
 * DESC: get, set키워드 구현 - 자동 구현 프로퍼티
-----------------------------------------------------------------------------*/
namespace _092_Property02
{
    class AA
    {
        private int num;
        private string name;

        public int NUM { get; set; }
        public string NAME { get; set; } = "NoName";
    }

    class Program
    {
        static void Main(string[] args) {
            AA aa = new AA();
            Console.WriteLine("aa.num: {0}", aa.NUM);
            Console.WriteLine("aa.NAME: {0}", aa.NAME);

            aa.NUM = 100;
            Console.WriteLine("aa.num: {0}", aa.NUM);
            aa.NAME = "Jack";
            Console.WriteLine("aa.NAME: {0}", aa.NAME);
        }
    }
}
