using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week1Selenium.TestScenarios.Kerkimi_ne_Intersport_
{
    class Kerkimi_ne_Intersport
    {
        [SetUp]
        public void SetupBeforeEachTest()
        {
            Action.InititalizeDriver("Chrome", Config.BaseUrl1);
        }

        [TearDown]
        public void AfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Action.MakeScreenshot(TestContext.CurrentContext.Test.Name);
            }
            Driver.driver.Quit();
        }

        [Test]
        public void Kerkimi_ne_Intersport1_Sport()
        {
            //IWebElement riinvestiIm = Driver.driver.FindElement(By.ClassName("menu-item-5"));


            Thread.Sleep(1000); // Me prit derisa tloadohet faqja
            Driver.driver.FindElement(By.XPath($"//a[@href='https://intersportks.com/']")).Click();

            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//a[@href='https://intersportks.com/?swoof=2&nitro=1&post_type=product']")).Click();



            Thread.Sleep(5000);

            //Done
        }

        [Test]
        public void Kerkimi_ne_Intersport1_Per_Femra()
        {
            //IWebElement riinvestiIm = Driver.driver.FindElement(By.ClassName("menu-item-5"));


            Thread.Sleep(1000); // Me prit derisa tloadohet faqja
            Driver.driver.FindElement(By.XPath($"//a[@href='https://intersportks.com/']")).Click();

            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//a[@href='https://intersportks.com/?swoof=2&nitro=1&post_type=product&product_cat=femra']")).Click();



            Thread.Sleep(5000);

            //Done

            // Assert.IsTrue(Driver.driver.PageSource.Contains(Config.AlertMessages.InvalidCredentials));
        }
    }
}

