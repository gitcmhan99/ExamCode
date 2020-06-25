using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _140_Thread_Abort_Join_Interrupt
 * DESC: Thread 중지하기
 * -----------------------------------------------------------------------------*/
namespace _140_Thread_Abort_Join
{
    class Program
    {
        static void RunThread(int index) {
            DateTime start = DateTime.Now;
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThread index: {0} Start", index));

            for(int i = 0; i < 5; i++) {
                Console.WriteLine("RunThread index: {0} sec: {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine(string.Format("RunThread index: {0} End", index));
            Console.WriteLine();
        }

        static void RunExeption(int index) {
            DateTime start = DateTime.Now;
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThread index: {0} Start", index));

            try {
                for(int i = 0; i < 5; i++) {
                    Console.WriteLine("RunThread index: {0} sec: {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                    Thread.Sleep(100);
                }

                Console.WriteLine(string.Format("RunThread index: {0} End", index));
                Console.WriteLine();
            }
            catch(ThreadInterruptedException e) { //System.Threading.ThreadAbortException이라는 예외를 발생
                Console.WriteLine(e);
            }
            finally {
                Console.WriteLine("====  finally ===");
            }
        }

        static void Main(string[] args) {
            Thread aa = new Thread(() => RunThread(0));
            aa.Start();
            Thread.Sleep(300);
            aa.Abort();
            Console.WriteLine(string.Format("Abort"));
            Console.WriteLine();

            
            Thread bb = new Thread(() => RunThread(1));
            bb.Start();
            Thread.Sleep(300);
            bb.Join();
            Console.WriteLine(string.Format("Join"));
            Console.WriteLine();


            Thread cc = new Thread(() => RunExeption(2));
            cc.Start();
            Thread.Sleep(300);
            //cc.Abort();
            cc.Interrupt();
            Console.WriteLine(string.Format("Interrupt"));
            Console.WriteLine();
        }
    }
}
