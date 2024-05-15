using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NUnit.Framework;

using OpenQA.Selenium;
using TechTalk.SpecFlow;

using SpecflowAppium.Pages;
using System.Threading;

[assembly:Parallelizable(ParallelScope.Fixtures)]
namespace SpecflowAppium.Steps
{
    [Binding]
    public class SignUpSteps
    {

        private IWebDriver driver;

        private HomePage _homePage;


        public SignUpSteps(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }
        
        [Given("I am on Home page")]
        public void GivenIamOnHomePage()
        {
           _homePage = new HomePage(driver);
        }

        [When("I proceed to Sign up page")]
        public void WhenIProceedToSignUpPage() {
            _homePage.ClickNextButton();
        }
    }
}