using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using SpecflowAppium.Pages;

namespace Specflow_Appium.Pages
{
    public class WebViewPage : AbstractPage
    {

        [FindsByAndroidUIAutomator(XPath = "//android.widget.TextView[contains(@text,'Web View')]")]
        private IWebElement _marker;
        public WebViewPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsPageOpened() {
            try {
                return _marker.Displayed;
            } catch (NoSuchElementException e) {
                return false;
            }
        }
    }
}