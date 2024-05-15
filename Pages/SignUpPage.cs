using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Support.PageObjects;
using Specflow_Appium.Pages;
using Specflow_Appium.Pages.Enums;

namespace SpecflowAppium.Pages
{
    public class SignUpPage : AbstractPage
    {

        [FindsByAndroidUIAutomator(ID = "com.solvd.carinademoapplication:id/name")]
        private IWebElement _nameInput;

        [FindsByAndroidUIAutomator(ID = "com.solvd.carinademoapplication:id/password")]
        private IWebElement _passwordInput;

        [FindsByAndroidUIAutomator(ID = "com.solvd.carinademoapplication:id/radio_female")]
        private IWebElement _femaleOption;

        [FindsByAndroidUIAutomator(ID = "com.solvd.carinademoapplication:id/radio_male")]
        private IWebElement _maleOption;

        [FindsByAndroidUIAutomator(ID = "com.solvd.carinademoapplication:id/checkbox")]
        private IWebElement _checkBox;

        [FindsByAndroidUIAutomator(ID = "com.solvd.carinademoapplication:id/login_button")]
        private IWebElement _submitButton;

        public SignUpPage(IWebDriver driver) : base(driver)
        {

        }

        public void TypeName(string name) {
            _nameInput.SendKeys(name);
        }

        public void TypePassword(string password) {
            _passwordInput.SendKeys(password);
        }

        public void CheckPolicy() {
           _checkBox.Click();
        }

        public void ChooseGender(Gender gender) {
            if (gender == Gender.MALE) {
                _maleOption.Click();
            } else {
                _femaleOption.Click();
            }
        }

        public WebViewPage Submit() {
            _submitButton.Click();
            return new WebViewPage(Driver);
        }

        public WebViewPage FillForm(string name, string password, Gender gender) {
            TypeName(name);
            TypePassword(password);
            ChooseGender(gender);
            CheckPolicy();
            return Submit();
        }

    }
}