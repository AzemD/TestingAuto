using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week1Selenium.TestScenarios.Kerkimi_ne_e_baa
{
    class KerkimiNeE_baa
    {
        [SetUp]
        public void SetupBeforeEachTest()
        {
            Action.InititalizeDriver("Chrome", Config.BaseUrl2);
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
        public void Kerkimin_ne_Ebaa_Teknik()
        {


            Thread.Sleep(1000); // Me prit derisa tloadohet faqja
            Driver.driver.FindElement(By.XPath($"//a[@href='https://e-baa.com/newdesign.php?kategoria=teknika']")).Click();

          
            Thread.Sleep(3000);

             
            //Done


           // Assert.IsTrue(Driver.driver.PageSource.Contains(Config.AlertMessages.InvalidCredentials));
        }
        [Test]
        public void Kerkimin_per_Veshje()
        {


            Thread.Sleep(1000); // Me prit derisa tloadohet faqja
            Driver.driver.FindElement(By.XPath($"//a[@href='https://e-baa.com/tekstil.php']")).Click();

   

       

            Thread.Sleep(6000);


            //Done


            // Assert.IsTrue(Driver.driver.PageSource.Contains(Config.AlertMessages.InvalidCredentials));
        }
    }
}
