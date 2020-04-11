using System;

namespace TugasInheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person("Khias", 21);
			person.GetInformation();
			
			Teacher teacher = new Teacher("Ari", 33, "190302", "Math");
			teacher.GetInformation();
			
			Student student = new Student("Khias Nurlatif Ari Subekti", 23, "105067", "khias.subekti@students.amikom.ac.id");
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
