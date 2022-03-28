using System;
namespace up_down_casting.Models
{
	public class Group
	{
        public int No {get;}
        private static int _no = 100;
        private string _No;
        private object[] _students;
        private Student[] student;

        static void Main(string[] args){

        }
        public void AddStudent(Student student){
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public Student[] GetAllStudents() {
            return student;
        }
    }
}

