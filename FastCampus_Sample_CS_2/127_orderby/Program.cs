using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _127_orderby
 * DESC: orderby 기초
 * -----------------------------------------------------------------------------*/
namespace _127_orderby
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
                //orderby (data._kor + data._eng) descending //내림차순 정렬
                orderby (data._kor + data._eng) ascending //오름차순 정렬
                select data;

            foreach(var data in QueryData) {
                Console.Write("_id: " + data._id + " _name: " + data._name);
                Console.WriteLine(" _total: " + (data._kor + data._eng));
            }
        }
    }
}
