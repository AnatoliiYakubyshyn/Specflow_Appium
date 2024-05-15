using System;

using BoDi;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;

namespace SpecflowAppium.Hooks
{
    [Binding]
    public class Hooks
    {

        private IWebDriver driver;

        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("appium:platformName", "Android");
            appiumOptions.AddAdditionalCapability("appium:deviceName", "emulator-5554");
            appiumOptions.AddAdditionalCapability("appium:automationName", "UiAutomator2");
            appiumOptions.AddAdditionalCapability("appium:newCommandTimeout", 60);
            appiumOptions.AddAdditionalCapability("appium:noReset", false);
            appiumOptions.AddAdditionalCapability("appium:fullReset", false);
            appiumOptions.AddAdditionalCapability("appium:eventTimings", true);
            appiumOptions.AddAdditionalCapability("appium:printPageSourceOnFindFailure", true);
            appiumOptions.AddAdditionalCapability("appium:appPackage", "com.solvd.carinademoapplication");
            appiumOptions.AddAdditionalCapability("appium:appActivity", "ActivitySplash");
            appiumOptions.AddAdditionalCapability("appium:version", "2.0.1");
            appiumOptions.AddAdditionalCapability("appium:appWaitForLaunch", true);
            appiumOptions.AddAdditionalCapability("appium:automationVersion", "2.29.4");

            Uri url = new Uri("http://localhost:4723");

             driver =
                new AndroidDriver<AndroidElement>(url, appiumOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

    }
}
