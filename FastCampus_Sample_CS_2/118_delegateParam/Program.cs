using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _118_delegateParam
 * DESC: delegate 파라미터
-----------------------------------------------------------------------------*/
namespace _118_delegateParam
{
    delegate void delegateFunc();

    class MessageProcess
    {
        delegateFunc CallOkFunc;
        delegateFunc CallCancelFunc;

        public void Message(string msg, delegateFunc okFunc, delegateFunc cancelFunc) {
            CallOkFunc = okFunc;
            CallCancelFunc = cancelFunc;

            Console.WriteLine("Message: " + msg + " (0: ok,  1: cancel)");

            string inputStr = Console.ReadLine();

            if(inputStr.Equals("0")) {
                CallOkFunc();
            }
            else {
                CallCancelFunc();
            }
        }
    }

    class Program
    {
        static void CallOK() {
            Console.WriteLine("CallOK");
        }

        static void CallCancel() {
            Console.WriteLine("CallCancel");
        }

        static void Main(string[] args) {
            MessageProcess msg = new MessageProcess();
            //msg.Message("Test Message", CallOK, CallCancel);

            msg.Message("Test Message",
                delegate ()
                {
                    Console.WriteLine("Call InDelegate");
                }
                ,CallCancel);
        }
    }
}
