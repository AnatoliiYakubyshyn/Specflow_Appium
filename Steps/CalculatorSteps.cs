using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Edge;
using Specflow_Appium.Pages.calculator;
using TechTalk.SpecFlow;

namespace Specflow_Appium.Steps
{
    [Binding]
    public class CalculatorSteps
    {

        private WindowsDriver<WindowsElement>_driver;

        private CalculatorPage calculatorPage;
        public CalculatorSteps(WindowsDriver<WindowsElement> webDriver)
        {
            this._driver = webDriver;
            calculatorPage = new CalculatorPage(_driver);
        }

        [When("I add (.*) and (.*)")]
        public void WhenIAddNumbers(int number1,int number2) {
            calculatorPage.Clear();
            calculatorPage.AddIntNumbers(number1,number2);
        }
        [Then("I get (.*)")]
        public void ThenIget(int number3) {
            Assert.AreEqual(calculatorPage.GetIntResult(),number3);
        } 
    }
}