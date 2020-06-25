using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint02
{
    class Program
    {
        const int DELAY_TIME = 300;
        const string LINE = "--------------------------------------------";
        const int END_LINE = 42;
        const int FINISH_LINE = 40;

        static int runA = 0;
        static int runB = 0;
        static int runC = 0;
        static int runD = 0;

        static void Main(string[] args) {
            Random rnd = new Random();

            Start();

            while(true) {
                ClearScreen();

                Process(ref rnd);

                UpdateScreen();

                if(CheckResult() == false)
                    break;
            }
        }

        static void Start() {
        }

        static void ClearScreen() {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void Process(ref Random rnd) {
            runA++;
            runB++;
            runC++;
            runD++;

            int rndNum = rnd.Next(0, 4);
            int rndRun = rnd.Next(0, 2);

            switch(rndNum) {
                case 0:
                    runA += rndRun;
                    break;
                case 1:
                    runB += rndRun;
                    break;
                case 2:
                    runC += rndRun;
                    break;
                case 3:
                    runD += rndRun;
                    break;
            }
        }

        static void UpdateScreen() {
            Console.WriteLine(LINE);

            for(int i = 0; i < runA; i++)
                Console.Write(" ");
            Console.Write("1");

            for(int i = FINISH_LINE - runA; i >= 0; i--)
                Console.Write(" ");
            Console.WriteLine("|");

            for(int i = 0; i < runB; i++)
                Console.Write(" ");
            Console.Write("2");

            for(int i = FINISH_LINE - runB; i >= 0; i--)
                Console.Write(" ");
            Console.WriteLine("|");

            for(int i = 0; i < runC; i++)
                Console.Write(" ");
            Console.Write("3");

            for(int i = FINISH_LINE - runC; i >= 0; i--)
                Console.Write(" ");
            Console.WriteLine("|");

            for(int i = 0; i < runD; i++)
                Console.Write(" ");
            Console.Write("4");

            for(int i = FINISH_LINE - runD; i >= 0; i--)
                Console.Write(" ");
            Console.WriteLine("|");

            Console.WriteLine(LINE);
        }

        static bool CheckResult() {
            if(runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE) {
                string strResult = "결과:  ";

                if(runA >= END_LINE)
                    strResult += "!!1번 선수 우승!!";
                else if(runB >= END_LINE)
                    strResult += "!!2번 선수 우승!!";
                else if(runC >= END_LINE)
                    strResult += "!!3번 선수 우승!!";
                else
                    strResult += "!!4번 선수 우승!!";

                Console.WriteLine(strResult);
                Console.Write("다시 하시려면 0번을 누르세요~~");

                if(0 == int.Parse(Console.ReadLine())) {
                    runA = 0;
                    runB = 0;
                    runC = 0;
                    runD = 0;

                    return true;
                }
                else {
                    return false;//break;
                }
            }
            return true;
        }
    }
}
