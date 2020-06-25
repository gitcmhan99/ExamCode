using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _110_Dictionary
 * DESC: Queue<T> 기초
-----------------------------------------------------------------------------*/
namespace _110_Dictionary
{
    class Program
    {
        static void Main(string[] args) {
            Dictionary<string, int> dictionaryAA = new Dictionary<string, int>();
            dictionaryAA.Add("10", 10);
            dictionaryAA.Add("20", 20);
            dictionaryAA["30"] = 30;

            foreach(var key in dictionaryAA.Keys) {
                Console.WriteLine("key: {0}, data: {1}", key, dictionaryAA[key]);
            }

            Console.WriteLine("");

            Dictionary<int, string> dictionaryInit = new Dictionary<int, string>() { 
                [1] = "Hello",
                [100] = "Dictionary",
                [1000] = "Good!!",
            };

            foreach(var key in dictionaryInit.Keys) {
                Console.WriteLine("key: {0}, data: {1}", key, dictionaryInit[key]);
            }

            string getValue = string.Empty;
            dictionaryInit.TryGetValue(1, out getValue);
            Console.WriteLine("\nTryGetValue: " + getValue);

            dictionaryInit.TryGetValue(11, out getValue);
            Console.WriteLine("\nTryGetValue: " + getValue);
        }
    }
}
