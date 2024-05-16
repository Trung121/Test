using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

	public class Test1
	{
		public string Name { get { return name; }
			set { name = value; } }

		public int Age {
			get { return age; }
			set { age = value; }
		}

		private string name = "Test";

		private int age = 10;
	}

	public class Test2 : Test1
	{
		
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Test1 test = new Test1();
			Console.WriteLine("{0} : {1}", test.Name, test.Age);
			test.Name = "Trung";
			test.Age = 25;
			Console.WriteLine("{0} : {1}", test.Name, test.Age );
			Console.ReadLine();
		}
	}
}
