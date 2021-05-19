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
    public sealed class IndexSteps
    {

        public Settings _settings;
        IndexSteps(Settings settings) => _settings = settings;

        IndexPage indexPage;

        [Given(@"mark wants to update his first name")]
        public void GivenMarkWantsToUpdateHisFirstName()
        { 
        }
        [When(@"clicks on My personal information")]
        public void WhenClicksOnMyPersonalInformation()
        {
            indexPage = new IndexPage(_settings.configurations.driver);
            indexPage.navigateToPersonalInformationInMyAccountSection();
        }
        [Then(@"mark should see purchased T-Shirt in order history")]
        public void ThenMarkShouldSeePurchasedT_ShirtInOrderHistory()
        {
            indexPage = new IndexPage(_settings.configurations.driver);
            indexPage.navigateToMyAccountSection()
                .navigateToOrderHistoryAndDetailsInMyAccountSection()
                .verifyPlacedOrderDetails();
        }





    }
}
