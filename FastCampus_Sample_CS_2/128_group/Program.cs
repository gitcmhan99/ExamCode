using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _128_group
 * DESC: group 기초
 * -----------------------------------------------------------------------------*/
namespace _128_group
{
    struct Student
    {
        public int _id;
        public string _name;
        public int _kor;
        public int _eng;

        public Student(int _id, string _name, int _kor, int _eng) {
            this._id = _id;
            this._name = _name;
            this._kor = _kor;
            this._eng = _eng;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Student[] arrStudents =
            {
                new Student(){_id = 100, _name ="John", _kor = 100, _eng = 20},
                new Student(){_id = 200, _name ="Jane", _kor = 80, _eng = 20},
                new Student(300, "Tom", 50, 60),
                new Student(400, "Max", 80, 80),
                new Student(500, "Jack", 70, 70),
            };

            var QueryData =
                from data in arrStudents
                orderby (data._eng + data._kor) descending
                group data by (data._eng + data._kor) < 150;

            foreach(var data in QueryData) {
                string str = data.Key ? "합이 150보다 작은경우: " : "합이 150보다 큰경우: ";
                Console.WriteLine(str);

                foreach(var item in data)
                    Console.WriteLine("\t{0}: {1}", item._name, (item._kor + item._eng));
            }

            //위에 코드를 아래 코드처럼 분리해서 비교하기
            List<Student> listMaxStudents = null;
            List<Student> listMinStudents = null;

            foreach(var data in QueryData) {
                
                if(false == data.Key) //합이 150보다 큰경우
                    listMaxStudents = data.ToList();
                else
                    listMinStudents = data.ToList();
            }

            for(int i = 0; i < listMaxStudents.Count; i++) {
                Console.WriteLine("합이 150보다 큰경우: " + listMaxStudents[i]._name);
            }

            for(int i = 0; i < listMinStudents.Count; i++) {
                Console.WriteLine("합이 150보다 작은경우: " + listMinStudents[i]._name);
            }
        }
    }
}
