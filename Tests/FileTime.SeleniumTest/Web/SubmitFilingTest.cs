using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileTime.SeleniumTest.Web
{
	public class SubmitFilingTest
	{
		public void RunTest(int i)
		{
			Console.WriteLine("Test-" + i + "-Started");
			IWebDriver driver = new FirefoxDriver();

		}
	}
}
