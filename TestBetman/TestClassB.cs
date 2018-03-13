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
            /*    Assert.Multiple(() =>
                    {
                        Assert.AreEqual("Logind", title);
                    });*/

          /*  try
            {
                Assert.AreEqual("Login", title);
                Console.WriteLine("\n" + "Title matched and it is: " + title);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + "Title has not matched and the error is: " + e);
            }*/

            Assert.AreEqual("Loginn", title);
            Console.WriteLine("\n" + "Title matched and it is: " + title);

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
                dr.FindElement(By.Id("login-formm"));
                Console.WriteLine("The Login pop up is displayed.");
            }
            catch (Exception f)
            {
                Console.WriteLine("\n" + "The Login pop up is not displayed and the error is: " + "\n" + f);
            }
            dr.FindElement(By.Name("username")).SendKeys("sdf");

            dataSend.Add(dr);
            return dataSend;
        }
    }
}