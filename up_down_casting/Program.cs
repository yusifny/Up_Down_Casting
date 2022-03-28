using System;
using up_down_casting.Models;

namespace up_down_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

                student.Name = "John";
                student.Surname = "Shervon";
                student.Age = 18;
                student.Point = 99;

            student.ShowInfo();
        }
    }
}

