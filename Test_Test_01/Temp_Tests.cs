using System;
using NUnit.Framework;
using Test_Initialization_01.Base;

namespace Test_Test_01
{
    //[TestFixture("FireFox", "Develop1")]
    [TestFixture("Chrome", "Develop1")]

    public class Temp_Tests : Initialization
    {
        private string browser;
        private string env;

        public Temp_Tests(string browser, string env)
        {
            this.browser = browser;
            this.env = env;
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //Calls CSV file
            csvData.GetEnvironmentData();
        }

        //testing push 

        [SetUp]
        public void SetupTest()
        {
            base.PagesDef(browser);

            base.EnvironmentSetup(env);

            //Login as customer with login details from csv file
            base.GoTo(csvData.envUrl[customer]);
        }

        [Test]
        public void VerifyPage()
        {
            //webPage1.VerifyTextField("Google");
        }

        [TearDown]
        public void FinishTest()
        {
            base.CloseBrowser(Driver);
        }
    }
}
