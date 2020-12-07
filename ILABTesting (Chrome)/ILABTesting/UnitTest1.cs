using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace ILABTesting
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void NavigatingToTheiLabWebsite()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ilabquality.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
        }

             [TestMethod]
        public void HomePageTitleContainsILab()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            Assert.IsTrue(driver.Title.ToLower().Contains("ilab"));

            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ClickOnTheCareersTab()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='menu-item-1373']/a")).Click();
            Thread.Sleep(5000);

            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ClickOnTheSouthAfricanHyperlink()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='menu-item-1373']/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div[3]/div[2]/div/div/div[4]/a")).Click();
            Thread.Sleep(5000);

            driver.Close();
            driver.Quit();
        }


         [TestMethod]
        public void ClickOnTheFirstAvailableJobHyperlink()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='menu-item-1373']/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div[3]/div[2]/div/div/div[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div/div/div/div[1]/div[1]/div[2]/div[1]/a")).Click();
            Thread.Sleep(5000);

            driver.Close();
            driver.Quit();


        }


        [TestMethod]
        public void ClickOnTheApplyOnlineButton()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='menu-item-1373']/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div[3]/div[2]/div/div/div[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div/div/div/div[1]/div[1]/div[2]/div[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='wpjb-scroll']/div[1]/a")).Click();
            Thread.Sleep(5000);

            driver.Close();
            driver.Quit();


        }

        [TestMethod]
        public void InputtingAFirstName()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='menu-item-1373']/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div[3]/div[2]/div/div/div[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div/div/div/div[1]/div[1]/div[2]/div[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='wpjb-scroll']/div[1]/a")).Click();
            driver.FindElement(By.Id("applicant_name")).SendKeys("Kamogelo");
            Thread.Sleep(5000);

            driver.Close();
            driver.Quit();


        }


        [TestMethod]
        public void InputtingAnEmailAddress()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='menu-item-1373']/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div[3]/div[2]/div/div/div[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div/div/div/div[1]/div[1]/div[2]/div[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='wpjb-scroll']/div[1]/a")).Click();
            driver.FindElement(By.Id("applicant_name")).SendKeys("Kamogelo");
            driver.FindElement(By.Name("email")).SendKeys("automationAssessment@iLABQuality.com");
            Thread.Sleep(5000);

            driver.Close();
            driver.Quit();


        }

        public string GenerateCellphoneNumber()
        {
            var random = new Random((int)DateTime.Now.Ticks);
            int number1 = random.Next(0, 1);
            int number2 = random.Next(6, 8);
            int number3 = random.Next(0, 9);
            int number4 = random.Next(0, 9);
            int number5 = random.Next(0, 9);
            int number6 = random.Next(0, 9);
            int number7 = random.Next(0, 9);
            int number8 = random.Next(0, 9);
            int number9 = random.Next(0, 9);
            int number10 =random.Next(0, 9);

            return $"{number1}{number2}{number3}{number4}{number5}{number6}{number7}{number8}{number9}{number10}";

        }

        [TestMethod]
        public void AutoGenerateCellphoneNumebr()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='menu-item-1373']/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div[3]/div[2]/div/div/div[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div/div/div/div[1]/div[1]/div[2]/div[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='wpjb-scroll']/div[1]/a")).Click();
            driver.FindElement(By.Id("applicant_name")).SendKeys("Kamogelo");
            driver.FindElement(By.Name("email")).SendKeys("automationAssessment@iLABQuality.com");
            driver.FindElement(By.Name("phone")).SendKeys(GenerateCellphoneNumber());
            Thread.Sleep(5000);

            driver.Close();
            driver.Quit();


        }


        [TestMethod]
        public void VerifyIfErrorMessageDsiplaysWhenSendingApplicationWithoutAttachment()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ilabquality.com/");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='menu-item-1373']/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div[3]/div[2]/div/div/div[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/section/div[2]/div/div/div/div[3]/div[2]/div/div/div/div/div/div[1]/div[1]/div[2]/div[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='wpjb-scroll']/div[1]/a")).Click();
            driver.FindElement(By.Id("applicant_name")).SendKeys("Kamogelo");
            driver.FindElement(By.Name("email")).SendKeys("automationAssessment@iLABQuality.com");
            driver.FindElement(By.Name("phone")).SendKeys(GenerateCellphoneNumber());
            driver.FindElement(By.Id("wpjb_submit")).Click();
            Thread.Sleep(5000);
            var limessage = driver.FindElement(By.XPath("/html/body/section[2]/div[2]/div/div/div/div/div[2]/div[2]/form/fieldset[1]/div[5]/div/ul/li"));
            Assert.IsTrue(limessage.Text.Contains("You need to upload at least one file."));
            driver.Close();
            driver.Quit();

        }




    }

}
