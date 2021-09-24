using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace SauceLabsTestProject
{
    public class JumpToStartTest
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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60)) { PollingInterval = TimeSpan.FromMilliseconds(10) };            
            wait.Until(x => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").ToString() == "complete");
        }

        private bool IsPageLoaded()
        {
            Thread.Sleep(TimeSpan.FromSeconds(70));
            if (driver.FindElement(By.CssSelector("div.e-custom-event-marker")).Displayed == true)
                return true;
            else
                return false;
        }

        [Test]
        public void TestJumpToStartTaskDate1()
        {
            //driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            driver.Url = "https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task";
            CheckForPageLoad();
            IsPageLoaded();
            Actions actions = new Actions(driver);

            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));

            IWebElement scrollContainer = driver.FindElement(By.ClassName("e-chart-scroll-container"));

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollTo({left: 20})", scrollContainer);
            Thread.Sleep(5000);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus()", scrollContainer);
            Thread.Sleep(5000);

            actions.MoveToElement(scrollContainer).Perform();
            Thread.Sleep(5000);
            actions.MoveToElement(scrollContainer,100,10).Perform();
            Thread.Sleep(5000);            

            IWebElement leftLabelContainer = driver.FindElement(By.XPath("(//*[@class=\"e-left-label-container\"])[2]/.."));
            leftLabelContainer.Click();   

            Thread.Sleep(5000);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", leftLabelContainer);
            Thread.Sleep(5000);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus()", leftLabelContainer);

            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", leftLabelContainer);
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", leftLabelContainer);
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", leftLabelContainer);
            

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].dispatchEvent(new MouseEvent(\"click\", {bubbles: true, cancelable: true, view: window  }) )", leftLabelContainer);
            // ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].dispatchEvent(new Event('touchstart', true, true));", leftLabelContainer);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.opacity = '1.0';", leftLabelContainer);

            IWebElement jumpToTask = driver.FindElement(By.XPath("//*[@data-automation-id='gantt__totask']"));
            Console.WriteLine("Jump to task before removing u-hide: " + jumpToTask.Displayed);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.opacity = '1.0';", jumpToTask);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].classList.remove(\"u-hide\");", jumpToTask);
           // ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.position=\"absolute\";arguments[0].style.left=10;arguments[0].style.top=50;", jumpToTask);

            Console.WriteLine(jumpToTask.Displayed + "  " + jumpToTask.Location.X + "," + jumpToTask.Location.Y);

            actions.MoveToElement(scrollContainer, 0, 10).Perform();

            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        
    }
}