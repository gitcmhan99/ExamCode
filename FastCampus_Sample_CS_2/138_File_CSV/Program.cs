using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*-----------------------------------------------------------------------------
 * Name: _138_File_CSV
 * DESC: CSV데이터 기초
 * using System.IO;
 * -----------------------------------------------------------------------------*/
namespace _138_File_CSV
{
    class Stage {
        public string stage { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public int finish { get; set; }
        public int gold { get; set; }
    }

    class Program
    {
        static void Main(string[] args) {
            const string fileName = "test.csv";

            int index = 0;
            List<Stage> listStage = new List<Stage>();

            using(StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open))) {
                //while(false == sr.EndOfStream) {
                //    Console.WriteLine(sr.ReadLine());
                //}

                while(false == sr.EndOfStream) {
                    string readStr = sr.ReadLine();

                    if(index++ >= 1) {
                        string[] splitData = readStr.Split(',');

                        Stage temp = new Stage();
                        temp.stage = splitData[0];
                        temp.min = Convert.ToInt32(splitData[1]);
                        temp.max = Convert.ToInt32(splitData[2]);
                        temp.finish = Convert.ToInt32(splitData[3]);
                        temp.gold = Convert.ToInt32(splitData[4]);
                        listStage.Add(temp);
                    }
                }
            }

            foreach(var d in listStage) {
                Console.Write("{0} {1} {2} {3} {4}", d.stage, d.min, d.max, d.finish, d.gold);
                Console.WriteLine();
            }

            string str = "0, 1, 2, 3, 4, 5";
            string[] splitRead = str.Split(',');
            for(int i = 0; i < splitRead.Length; i++) {
                Console.Write(" {0} ", splitRead[i]);
            }
        }
    }
}
