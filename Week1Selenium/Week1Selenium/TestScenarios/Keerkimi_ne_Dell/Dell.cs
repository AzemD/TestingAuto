using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week1Selenium.TestScenarios.Perkthimi_i_faqes_
{
    class Dell
    {
        [SetUp]
        public void SetupBeforeEachTest()
        {
            Action.InititalizeDriver("Chrome", Config.BaseUrl3);
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
        public void Kerkimi_i_Pc_Lloptop()
        {


            Thread.Sleep(3000); // Me prit derisa tloadohet faqja
            Driver.driver.FindElement(By.XPath($"//a[@href='https://www.dell.com/ai/empresas/p/deals/smallbusiness-deals?s=bsd&l=en']")).Click();

           
            Thread.Sleep(6000); 


            //Done
        }
        [Test]
        public void Kerkimi_i_LogIn_ne_Dell()
        {


            Thread.Sleep(5000); // Me prit derisa tloadohet faqja

            Driver.driver.FindElement(By.Id("login")).Click();

          


            Thread.Sleep(6000); //login t1li


            //Done


            
        }
    }
}
