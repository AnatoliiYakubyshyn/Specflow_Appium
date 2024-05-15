using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Appium;

namespace SpecflowAppium.Pages
{
    public abstract class AbstractPage
    {
        protected IWebDriver Driver {get;set;}

        public AbstractPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(Driver,this, new AppiumPageObjectMemberDecorator(new TimeOutDuration(TimeSpan.FromSeconds(5))));
        }
    }
}