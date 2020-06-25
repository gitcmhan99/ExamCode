using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _108_Queue
 * DESC: Queue<T> 기초
-----------------------------------------------------------------------------*/
namespace _108_Queue
{
    class Program
    {
        static void Main(string[] args) {
            Queue<int> queueAA = new Queue<int>();
            queueAA.Enqueue(1);
            queueAA.Enqueue(2);

            for(int i = 0; i < 10; i++) {
                queueAA.Enqueue(i);
            }

            Console.WriteLine("queue data: {0}", queueAA.Peek());

            while(queueAA.Count > 0) {
                Console.WriteLine("queue data: {0}, count: {1}", queueAA.Dequeue(), queueAA.Count);
            }

            //배열데이터로 초기화
            Console.WriteLine("\n배열데이터로 초기화");
            string[] arrData = { "AA", "BB", "CC"};
            Queue<string> queueArr = new Queue<string>(arrData);

            foreach(var data in queueArr) {
                Console.WriteLine("queueArr data: " + data);
            }
        }
    }
}
