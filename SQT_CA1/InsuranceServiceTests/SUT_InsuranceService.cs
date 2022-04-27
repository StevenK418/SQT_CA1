using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44360/Webform1");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            Assert.AreEqual("Result: 0.00", driver.FindElement(By.Id("MainContent_resultField")).Text);
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("22");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            Assert.AreEqual("Result: 5.00", driver.FindElement(By.Id("MainContent_resultField")).Text);
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("37");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            Assert.AreEqual("Result: 2.50", driver.FindElement(By.Id("MainContent_resultField")).Text);
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("55");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            Assert.AreEqual("Result: 0.38", driver.FindElement(By.Id("MainContent_resultField")).Text);
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_location")).Clear();
            driver.FindElement(By.Id("MainContent_location")).SendKeys("urban");
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("10");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            Assert.AreEqual("Result: 0.00", driver.FindElement(By.Id("MainContent_resultField")).Text);
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("22");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            Assert.AreEqual("Result: 6.00", driver.FindElement(By.Id("MainContent_resultField")).Text);
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("37");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            Assert.AreEqual("Result: 5.00", driver.FindElement(By.Id("MainContent_resultField")).Text);
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("55");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]/div")).Click();
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_location")).Clear();
            driver.FindElement(By.Id("MainContent_location")).SendKeys("London");
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("10");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("22");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("37");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("55");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("-1");
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_location")).Clear();
            driver.FindElement(By.Id("MainContent_location")).SendKeys("urban");
            driver.FindElement(By.Id("MainContent_age")).Click();
            driver.FindElement(By.Id("MainContent_age")).Clear();
            driver.FindElement(By.Id("MainContent_age")).SendKeys("-7");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[4]")).Click();
            driver.FindElement(By.Id("MainContent_location")).Clear();
            driver.FindElement(By.Id("MainContent_location")).SendKeys("London");
            driver.FindElement(By.Id("MainContent_btnSubscribe")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
