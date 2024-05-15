using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecflowAppium.Pages
{
    public class HomePage : AbstractPage
    {

        [FindsByAndroidUIAutomator(ID = "com.solvd.carinademoapplication:id/next_button")]
        private IWebElement nextbutton;
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickNextButton() {
            nextbutton.Click();
        }
    }
}