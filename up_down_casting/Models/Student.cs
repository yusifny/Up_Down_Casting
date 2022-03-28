using System;
namespace up_down_casting.Models
{
	public class Student
	{
		private static int _id = 1; 
        public int Id { get; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public double Point { get; set; }
		
		public void Group(string aName, string aSurname, int aAge, double aPoint)
		{
			_id++;
			this.Name = aName;
			this.Surname = aSurname;
			this.Age = aAge;
			this.Point = aPoint;
		}
		public void ShowInfo(){
            Console.WriteLine($" ID: {Id}\n Name: {Name}\n Surname: {Surname}\n Age: {Age}\n Point: {Point}");
		}
		
	}
}