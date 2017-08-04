using System;
using System.Threading;
using OpenQA.Selenium;
using Test_Initialization_01.Base;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace Test_Initialization_01.Pages
{
    public class WebPage1 : Initialization
    {
        public WebPage1(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(browser, this);
        }

        //---------- E L E M E N T S ----------//

        //Test Text
        [FindsBy(How = How.Id, Using = "_eEe")]
        public IWebElement TextField { get; set; }

        //Search field
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement SearchField { get; set; }


        //---------- A C T I O N S ----------//


        //Verify Text field
        public void VerifyTextField(string text)
        {
            Assert.IsTrue(TextField.Text.Contains(text));
        }

        //Search Google
        public void SearchGoogle(string search)
        {
            SearchField.SendKeys(search);
            SearchField.SendKeys(Keys.Enter);
        }
    }
}
