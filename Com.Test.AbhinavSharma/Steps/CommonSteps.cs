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
    public sealed class CommonSteps
    {

        public Settings _settings;
        public CommonSteps(Settings settings) => _settings = settings;

        public string inputWebsiteName = "";
        IndexPage indexPage;
        //CareersPage careersPage;


        [Given(@"mark has a valid account with ""(.*)""")]
        public void GivenMarkHasAValidAccountWith(
            string websiteName)
        {
            if (websiteName.Equals("xxx")) websiteName = _settings.configurations.baseUrl;
            GenericHelper.OutputFormattedAs("", "Website Name", websiteName);
            inputWebsiteName = websiteName;
        }


        [Given(@"performs login with user-name as ""(.*)"" and password as ""(.*)""")]
        public void GivenPerformsLoginWithUser_NameAsAndPasswordAs(
              string userName
            , string password)
        {
            if (userName.Equals("xxx")) userName = _settings.configurations.userName;
            if (password.Equals("xxx")) password = _settings.configurations.password;
            GenericHelper.OutputFormattedAs("", "user-name used for login", userName);
            GenericHelper.OutputFormattedAs("", "password used for login", password);
            
            indexPage = new IndexPage(_settings.configurations.driver);
            indexPage
                .goToPage(inputWebsiteName)
                .performLogin(userName, password);
        }
    }
}
