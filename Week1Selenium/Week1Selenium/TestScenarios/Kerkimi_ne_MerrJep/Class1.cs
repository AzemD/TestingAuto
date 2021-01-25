using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Week1Selenium.TestScenarios.Kerkimi_ne_MerrJep
{
    class Class1
    {
        [SetUp]
        public void SetupBeforeEachTest()
        {
            Action.InititalizeDriver("Chrome", Config.BaseUrl);
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
        public void Kerkimin_per_ne_Drenas()
        {
         
           
            Thread.Sleep(1000); // Me prit derisa tloadohet faqja
            Driver.driver.FindElement(By.XPath($"//a[@href='https://www.merrjep.com/shpalljet/']")).Click();

            Thread.Sleep(1000);

            Driver.driver.FindElement(By.Id("Search")).SendKeys(Config.MerrJep.search);
            Thread.Sleep(3000);
            Driver.driver.FindElement(By.Id("global-search-button")).Click();

            Thread.Sleep(6000);

          
            //Done
            

            // Assert.IsTrue(Driver.driver.PageSource.Contains(Config.AlertMessages.InvalidCredentials));
        }

        [Test]
        public void Kerkimin_per_Vetura()
        {


            Thread.Sleep(1000); // Me prit derisa tloadohet faqja
            Driver.driver.FindElement(By.XPath($"//a[@href='https://www.merrjep.com/shpalljet/']")).Click();

            Thread.Sleep(1000);

            Driver.driver.FindElement(By.Id("Search")).SendKeys(Config.MerrJep.serach1);
            Thread.Sleep(3000);
            Driver.driver.FindElement(By.Id("global-search-button")).Click();

            Thread.Sleep(6000);


            //Done


            //Assert.IsTrue(Driver.driver.PageSource.Contains(Config.AlertMessages.InvalidCredentials));
        }
    }
}
