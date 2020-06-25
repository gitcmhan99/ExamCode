using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _119_event
 * DESC: event 기초
-----------------------------------------------------------------------------*/
namespace _119_event
{
    public delegate void delegateEvent(string msg);

    class InDelegate
    {
        public delegateEvent myDelegate;
        public event delegateEvent myEvent;

        public void DoEvent(int a, int b) {
            if(null != myEvent)
                myEvent("DoEvent: " + (a + b)); //== ConsoleFunc("DoEvent: " + (a + b));
        }
    }

    class Program
    {
        static public void ConsoleFunc(string msg) {
            Console.WriteLine("ConsoleFunc: " + msg);
        }

        static void Main(string[] args) {
            InDelegate id = new InDelegate();
            //id.myEvent += new delegateEvent(ConsoleFunc);   
            id.myEvent += ConsoleFunc;
            //id.myEvent = ConsoleFunc; //대입연산자 사용 불가..

            id.myDelegate = ConsoleFunc;

            id.myDelegate("Test"); //클래스 외부 직접 호출 가능..
            //id.myEvent("Test"); //클래스 외부에서 직접 호출 불가..

            for(int i = 0; i < 10; i++) {
                if(i == 9) id.myEvent -= ConsoleFunc;
                id.DoEvent(i+1, i+2); //10, 11
            }
        }
    }
}
