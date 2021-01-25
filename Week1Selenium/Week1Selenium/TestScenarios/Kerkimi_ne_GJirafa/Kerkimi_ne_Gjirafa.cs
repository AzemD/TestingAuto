using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week1Selenium.TestScenarios.Kerkimi_ne_GJirafa
{
    class Kerkimi_ne_Gjirafa
    {
        [SetUp]
        public void SetupBeforeEachTest()
        {
            Action.InititalizeDriver("Chrome", Config.BaseUrl4);
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
        public void Kerkimin_per_smarphone_tablet_PaisjeSmart()

        {
            Thread.Sleep(3000);

 

             Driver.driver.FindElement(By.XPath($"//a[@href='https://gjirafa50.com/celulare-tablete-dhe-pajisje-smart/']")).Click();
            Thread.Sleep(3000);

            Driver.driver.FindElement(By.XPath($"//a[@href='https://gjirafa50.com/celulare-tablete-dhe-pajisje-smart/ore-dhe-mates-aktiviteti-smart/mates-aktiviteti/xiaomi-mi-band-5/']")).Click();

            Thread.Sleep(6000);


            //Done
        }

        [Test]
        public void Kerkimin_per_Tv_audio_video()

        {
            Thread.Sleep(3000);



            Driver.driver.FindElement(By.XPath($"//a[@href='https://gjirafa50.com/tv-video-dhe-audio/']")).Click();



            Thread.Sleep(6000);

            Driver.driver.FindElement(By.XPath($"//a[@href='https://gjirafa50.com/tv-video-dhe-audio/tv/4k-ultrahd/televizor-samsung-ue43tu7172---108cm/']")).Click();

            Thread.Sleep(6000);
            //Done
        }
    }
}
