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
    public sealed class CategorySteps
    {

        public Settings _settings;
        public CategorySteps(Settings settings) => _settings = settings;

        CategoryPage categoryPage;

        [Given(@"mark wants order a T-Shirt for his wife")]
        public void GivenMarkWantsOrderAT_ShirtForHisWife()
        { 
        }
        [When(@"mark selects & completes the purchase")]
        public void WhenMarkSelectsCompletesThePurchase()
        {
            categoryPage = new CategoryPage(_settings.configurations.driver);
            categoryPage
                .navigateToTShirtCategory()
                .proceedToCheckout();
        }









    }
}
