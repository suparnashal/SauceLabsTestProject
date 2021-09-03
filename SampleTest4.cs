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

        [Test]
        public void TestGoogleLink()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(TimeSpan.FromSeconds(30));
            driver.FindElement(By.XPath("//*[@name='q']"));
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(TimeSpan.FromSeconds(30));
            driver.FindElement(By.XPath("//*[@name='q']"));
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        [Test]
        public void TestGoogleLink2()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(TimeSpan.FromSeconds(30));
            driver.FindElement(By.XPath("//*[@name='q']"));
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink3()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(TimeSpan.FromSeconds(30));
            driver.FindElement(By.XPath("//*[@name='q']"));
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGoogleLink4()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(TimeSpan.FromSeconds(30));
            driver.FindElement(By.XPath("//*[@name='q']"));
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("BST");
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}