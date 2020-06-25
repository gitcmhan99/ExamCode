using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _129_group2
 * DESC: group 활용
 * -----------------------------------------------------------------------------*/
namespace _129_group2
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
                new Student(300, "Tom", 51, 60),
                new Student(400, "Max", 83, 86),
                new Student(500, "Jack", 70, 70),
            };

            var QueryData =
                from data in arrStudents
                group data by ((data._eng + data._kor) / 2) / 10 into gTemp
                orderby gTemp.Key ascending
                select gTemp;

            foreach(var data in QueryData) {
                Console.WriteLine("data: {0} 에서 {1}", data.Key * 10, (data.Key + 1) * 10);

                foreach(var item in data) {
                    Console.WriteLine("\t name: {0}, avg: {1}", item._name, (item._kor + item._eng) / 2f);
                }
            }
        }
    }
}
