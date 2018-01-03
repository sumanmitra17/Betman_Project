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
            try
            {
                Assert.AreEqual("Login", title);
                Console.WriteLine("Title matched and it is: " + title);
            }
            catch (Exception e)
            {
                Console.WriteLine("Title has not matched and it appears as: " + e);
            }

            ArrayList dataSend = new ArrayList();
            dataSend.Add(dr);
            return dataSend;
        }


        public static ArrayList Login_Submission(ArrayList dataRequired)
        {
            IWebDriver dr = (IWebDriver)dataRequired[0];

            ArrayList dataSend = new ArrayList();

            try
            {
                dr.FindElement(By.Id("login-form"));
                Console.WriteLine("The Login pop up is displayed.");
            }
            catch (NoSuchElementException f)
            {
                Console.WriteLine("The Login pop up is not displayed.");
            }


            dataSend.Add(dr);
            return dataSend;
        }
    }
}
