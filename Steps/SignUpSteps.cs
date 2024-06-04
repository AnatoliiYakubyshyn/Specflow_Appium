using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NUnit.Framework;

using OpenQA.Selenium;
using TechTalk.SpecFlow;

using SpecflowAppium.Pages;
using System.Threading;
using Specflow_Appium.Pages.Enums;
using Specflow_Appium.Pages;

[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace SpecflowAppium.Steps
{
    [Binding]
    public class SignUpSteps
    {

        private IWebDriver driver;

        private HomePage _homePage;

        private SignUpPage _signUpPage;

        private WebViewPage _webViewPage;


        // public SignUpSteps(IWebDriver webDriver)
        // {
        //     this.driver = webDriver;
        // }

        // [Given("I am on Home page")]
        // public void GivenIamOnHomePage()
        // {
        //     _homePage = new HomePage(driver);
        // }

        [Given("Hello")]
        public void GivenIamOnHomePage()
        {
           
        }

        // [When("I proceed to Sign up page")]
        // public void WhenIProceedToSignUpPage()
        // {
        //    _signUpPage = _homePage.ClickNextButton();
        // }

        // [When("Sign up with \"(.*)\" and \"(.*)\" and \"(.*)\"")]
        // public void WhenIEnterData(string name, string password, string gender)
        // {
        //     Gender genderEnum = gender == "Male" ? Gender.MALE : Gender.FEMALE;
        //     _webViewPage = _signUpPage.FillForm(name,password,genderEnum);
        // }
        
        // [Then("Web View page is opened")]
        // public void ThenWebViewPageIsOpened() {
        //     Assert.IsTrue(_webViewPage.IsPageOpened());
        // }
    }
}