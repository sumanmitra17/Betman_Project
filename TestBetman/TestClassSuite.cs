using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Collections;

namespace TestBetman
{
    [TestFixture]
    public class TestClassSuite
    {
        public static void TestSuite(IWebDriver dr)
        {
            //Adding these three variables in ArrayList
            ArrayList dataRequired = new ArrayList();
            dataRequired.Add(dr);


            ArrayList dataSet1 = new ArrayList();
            dataSet1 = TestClassB.TitleChecking(dataRequired);

            ArrayList dataSet2 = new ArrayList();
            dataSet2 = TestClassB.Login_Submission(dataSet1);

            ArrayList dataSet3 = new ArrayList();
           // dataSet3 = TestClassC.All_Tab_Selection(dataSet2);

            ArrayList dataSet4 = new ArrayList();
        }
    }
}

