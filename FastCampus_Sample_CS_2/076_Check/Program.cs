using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_Check
{
    class Program
    {
        static int InputNumber(int count) {
            int temp = 0;

            if(count == 0)
                Console.Write("첫번째 수를 입력 해 주세요?");
            else
                Console.Write("두번째 수를 입력 해 주세요?");

            temp = int.Parse(Console.ReadLine());

            return temp;
        }

        static void PrintResult(int a, int b) {
            Console.Write("{0} + {1} = {2}", a, b, (a + b));
            Console.WriteLine();
        }

        static bool CheckEnd() {
            bool isEnd = false;
            int temp = 0;

            Console.Write("추가로 계산할까요(1: OK, 0: NO, 단 총 10번까지 가능)");
            temp = int.Parse(Console.ReadLine());
            isEnd = (temp == 0);

            return isEnd;
        }

        static void Main(string[] args) {
            int[] InputA = new int[10];
            int[] InputB = new int[10];
            int indexCount = 0;

            while(true) {
                InputA[indexCount] = InputNumber(0);
                InputB[indexCount] = InputNumber(1);

                PrintResult(InputA[indexCount], InputB[indexCount]);

                indexCount++;

                if(indexCount >= 10 || CheckEnd()) {
                    for(int i = 0; i < indexCount; i++) {
                        PrintResult(InputA[i], InputB[i]);
                    }
                    break;
                }
            }
        }
    }
}
