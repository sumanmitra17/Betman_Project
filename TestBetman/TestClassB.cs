using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using System.Collections;

namespace TestBetman
{
   
    [TestFixture]
    public class TestClassB
    {
        public static ArrayList TitleChecking(ArrayList dataRequired)
        {
            IWebDriver dr = (IWebDriver)dataRequired[0];

            string title = dr.Title;
            Assert.AreEqual("CASHPOINT Partner Area", title);
            Console.WriteLine(title);

            ArrayList dataSend = new ArrayList();
            dataSend.Add(dr);

            //   extent.EndTest(test);

            return dataSend;
        }

        public static ArrayList Login_Submission(ArrayList dataRequired)
        {
            IWebDriver dr = (IWebDriver)dataRequired[0];

            ArrayList dataSend = new ArrayList();

            dr.FindElement(By.Id("username")).SendKeys("pitest1");
            dr.FindElement(By.Id("password")).SendKeys("$Pitest#1");
            IWebElement sw = dr.FindElement(By.Id("submit")); sw.Click();

       
            dataSend.Add(dr);

            //   extent.EndTest(test);

            return dataSend;
        }
    }
}
