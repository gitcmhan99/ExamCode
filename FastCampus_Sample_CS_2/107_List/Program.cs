using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _107_List
 * DESC: List<T> 기초
-----------------------------------------------------------------------------*/
namespace _107_List
{
    class Program
    {
        static void Main(string[] args) {
            List<int> ListAA = new List<int>();
            ListAA.Add(1);
            ListAA.Add(2);

            for(int i = 0; i < 10; i++) {
                ListAA.Add(i);
            }

            foreach(var data in ListAA) {
                Console.WriteLine("data: " + data);
            }

            Console.WriteLine("\n배열데이터로 초기화");
            string[] arrData = { "AA", "BB", "CC" };
            List<string> listArr = new List<string>(arrData);
            
            for(int i = 0; i < arrData.Length; i++) {
                Console.WriteLine("arrData: " + arrData[i]);
            }
        }
    }
}
