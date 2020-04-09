using System;

namespace TugasInheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person("Mike", 20);
			person.GetInformation();
			
			Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
			teacher.GetInformation();
			
			Student student = new Student("Sara", 19, "10506", "sara1234@amikom.ac.id");
			student.GetInformation();
			
			Console.ReadKey();
		}
	}
	
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		
		public Person(string name = "null", int age = 0)
		{
			Name = name;
			Age = age;
		}
		
		public void GetInformation()
		{
			Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
		}
	}
	
	public class Teacher : Person
	{
		public string TeacherId { get; set; }
		public string Subject { get; set; }
		
		public Teacher(string name = "null", int age = 0, string teacherId = "null", string subject = "null")
		{
			Name = name;
			Age = age;
			TeacherId = teacherId;
			Subject = subject;
		}
	}
	
	public class Student : Person
	{
		public string StudentId { get; set; }
		public string Email { get; set; }
		
		public Student(string name = "null", int age = 0, string studentId = "null", string email = "null")
		{
			Name = name;
			Age = age;
			StudentId = studentId;
			Email = email;
		}
	}
}
