using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _094_Check
{
    class CSaveNumber
    {
        private int number1 { get; set; }
        private int number2 { get; set; }

        public CSaveNumber() {
            number1 = 0;
            number2 = 0;
        }

        public void InputNumber(int count) {
            if(count == 0) {
                Console.Write("첫번째 수를 입력 해 주세요?");
                number1 = int.Parse(Console.ReadLine());
            }
            else {
                Console.Write("두번째 수를 입력 해 주세요?");
                number2 = int.Parse(Console.ReadLine());
            }
        }

        public void PrintResult() {
            Console.Write("{0} + {1} = {2}", number1, number2, (number1 + number2));
            Console.WriteLine();
        }
    }

    class Program
    {
        static bool CheckEnd(int index) {
            bool isEnd = false;
            int temp = 0;

            Console.Write("{0}번째 추가로 계산할까요(1: OK, 0: NO, 단 총 10번까지 가능)", (index + 1));
            temp = int.Parse(Console.ReadLine());
            isEnd = (temp == 0);

            return isEnd;
        }

        static void Main(string[] args) {
            int indexCount = 0;
            CSaveNumber[] saveNumbers = new CSaveNumber[10];

            while(true) {
                saveNumbers[indexCount] = new CSaveNumber();
                saveNumbers[indexCount].InputNumber(0);
                saveNumbers[indexCount].InputNumber(1);

                saveNumbers[indexCount].PrintResult();

                indexCount++;

                if(indexCount >= 10 || CheckEnd(indexCount)) {
                    for(int i = 0; i < indexCount; i++) {
                        saveNumbers[i].PrintResult();
                    }
                    break;
                }
            }
        }
    }
}
