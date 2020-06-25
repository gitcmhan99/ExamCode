using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _099_Indexer01
 * DESC: 
-----------------------------------------------------------------------------*/
namespace _099_Indexer01
{
    class AA
    {
        private int[] num = new int[10];

        public int this[int index]
        {
            get { return num[index]; }
            set { num[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            AA aa = new AA();

            for(int i = 0; i < 10; i++) {
                aa[i] = i;
            }

            aa[0] = 1000;
            aa[1] = 100;

            for(int i = 0; i < 10; i++) {
                Console.WriteLine("aa[{0}]: {1}", i, aa[i]);
            }
        }
    }
}
