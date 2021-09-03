using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SauceLabsTestProject
{
 public class SauceLabsSetup
    {
        public static IWebDriver webDriver;
        public void SetupSauceLabsDriver(TestContext context)
        {
            String username = "";
            String accesskey = "";
            String sauceurl = "https://ondemand.us-west-1.saucelabs.com/wd/hub";
            string saucelabsTunnelID = "bst-tunnel";           

            webDriver = new IOSDriver<IWebElement>(new Uri(sauceurl), GetAppiumOptions(username, accesskey, saucelabsTunnelID,context),TimeSpan.FromSeconds(200));            
        }

        public AppiumOptions GetAppiumOptions(string username,string accessKey,string tunnel,TestContext context)
        {
            var options = new AppiumOptions();
            //options.AddAdditionalCapability("name", "SauceLabsTest");           
            options.AddAdditionalCapability("name", context.Test.ClassName.Split('.').Last() + "_" + context.Test.MethodName);

            // Saucelabs configurations
            options.AddAdditionalCapability("username", username);
            options.AddAdditionalCapability("accessKey", accessKey);
            options.AddAdditionalCapability("tunnelIdentifier", tunnel);

            // Device configurations
            options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPad Pro (10.5 inch) Simulator");
            options.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "14.3");
            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            options.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 3600);

            // Mobile browser
            options.AddAdditionalCapability(MobileCapabilityType.BrowserName, "Safari");
            options.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
            return options;
        }
    }
}
