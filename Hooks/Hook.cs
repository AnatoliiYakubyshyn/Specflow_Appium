using System;

using BoDi;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium.Windows;

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

        // [AfterScenario]
        // public void TearDown()
        // {
        //     driver.Quit();
        // }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            var appiumOptions = new AppiumOptions();
            
            appiumOptions.AddAdditionalCapability("app", "win32calc.exe");
            string urlString = $"http://18.196.125.117:4723/wd/hub";
            Uri url = new Uri(urlString);

            // Initialize the WindowsDriver
            var driver = new WindowsDriver<WindowsElement>(url, appiumOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // Register the driver instance
            _container.RegisterInstanceAs<IWebDriver>(driver);

        }

    }
}
