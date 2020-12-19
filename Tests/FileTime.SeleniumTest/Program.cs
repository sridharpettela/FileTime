using FileTime.SeleniumTest.Web;
using System;
using System.Threading.Tasks;

namespace FileTime.SeleniumTest
{
	class Program
	{
		static void Main(string[] args)
		{
			SubmitFilingTest objSubmitFilingTest = new SubmitFilingTest();

			Parallel.For(0, 20, t => objSubmitFilingTest.RunTest(t));
			Console.WriteLine("Enter any Key....");
			Console.ReadLine();
		}
	}
}
