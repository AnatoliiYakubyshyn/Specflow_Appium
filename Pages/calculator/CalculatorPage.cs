using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.Events;

namespace Specflow_Appium.Pages.calculator
{
    public class CalculatorPage
    {

        private WindowsDriver<WindowsElement> _driver;

        private string buttonLocatorPrefix = "13"; 

        private string plussName = "Add";

        private string equalsName = "Equals";

        public CalculatorPage(WindowsDriver<WindowsElement> webDriver) {
            _driver = webDriver;
            
        }

        private void ClickDigit(char digit) {
            _driver.FindElementByAccessibilityId(buttonLocatorPrefix+digit).Click();
        }

        public void InputNumber(int number) {
            String strNumb = number.ToString();
            foreach (char c in strNumb) {
                ClickDigit(c);
            }
        }

        public void ClickPlus() {
            _driver.FindElementByName(plussName).Click();
        }

        public void ClickEquals() {
            _driver.FindElementByName(equalsName).Click();
        }

        public void AddIntNumbers(int number1, int number2) {
            InputNumber(number1);
            ClickPlus();
            InputNumber(number2);
            ClickEquals();
        }

        public WindowsElement GetResultElement() {
            return _driver.FindElementByName("Result");
        }

        public int GetIntResult() {
            return int.Parse(GetResultElement().Text);
        }

        public void Clear() {
            _driver.FindElementByName("Clear").Click();
        }
    }
}