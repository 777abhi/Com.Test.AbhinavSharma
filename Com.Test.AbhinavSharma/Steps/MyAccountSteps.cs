using OpenQA.Selenium;
using Com.Test.AbhinavSharma.Base;
using Com.Test.AbhinavSharma.PageObject;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Com.Test.AbhinavSharma.Helpers;

namespace Com.Test.AbhinavSharma.Steps
{
    [Binding]
    public sealed class MyAccountSteps
    {

        public Settings _settings;
        public MyAccountSteps(Settings settings) => _settings = settings;

        MyAccountPage myAccountPage;

        [When(@"updates First name as ""(.*)""")]
        public void WhenUpdatesFirstNameAs(
            string nameToBeUpdated)
        {
            myAccountPage = new MyAccountPage(_settings.configurations.driver);
            myAccountPage.UpdateFirstName(nameToBeUpdated, _settings.configurations.password);
        }

        [Then(@"mark should see updated first name in the profile section")]
        public void ThenMarkShouldSeeUpdatedFirstNameInTheProfileSection()
        {
            myAccountPage = new MyAccountPage(_settings.configurations.driver);
            myAccountPage.VerifyProfileInformationIsUpdated();
        }
    }
}
