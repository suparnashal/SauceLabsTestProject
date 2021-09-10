using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SauceLabsTestProject
{
    public class SampleTests4
    {
        public IWebDriver driver; 

        [SetUp]
        public void Setup()
        {
            new SauceLabsSetup().SetupSauceLabsDriver(TestContext.CurrentContext);
            driver = SauceLabsSetup.webDriver;
        }

        private void CheckForPageLoad()
        {          
            WebDriverWait  wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50)) { PollingInterval = TimeSpan.FromMilliseconds(10) };
            Thread.Sleep(3000);
            wait.Until(x => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").ToString() == "complete");            
        }

        private bool IsPageLoaded()
        {
            Thread.Sleep(TimeSpan.FromSeconds(30));
            if (driver.FindElement(By.XPath("//*[@name='q']")).Displayed == true)
                return true;
            else
                return false;
        }

        [Test]
        public void TestGoogleLink()
        {
            //driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Url ="https://www.google.com/";
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);            
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        [Test]
        public void TestGoogleLink2()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink3()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink4()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink5()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink6()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink7()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink8()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(TimeSpan.FromSeconds(30));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='q']"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Return);
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}