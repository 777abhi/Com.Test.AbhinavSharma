using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using Bogus;
using Com.Test.AbhinavSharma.Base;
using Com.Test.AbhinavSharma.Helpers;

namespace Com.Test.AbhinavSharma.PageObject
{
    public class MyAccountPage
    {
        public Settings _settings;
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@id='firstname']")]
        private IWebElement txtBoxFirstName;
        
        [FindsBy(How = How.XPath, Using = "//input[@id='old_passwd']")]
        private IWebElement txtBoxCurrentPassword;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Your personal information has been successfully up')]")]
        private IWebElement txtUpdateConfirmation;


        public MyAccountPage(Settings settings) => _settings = settings;
        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public MyAccountPage UpdateFirstName(
              string nameToBeUpdated
            , string password)
        {
            if (nameToBeUpdated.Equals("xxx"))
            {
                var f = new Faker();
                nameToBeUpdated = f.Person.FirstName;
                GenericHelper.OutputFormattedAs("", "New First Name selected for updating"
                    , nameToBeUpdated);
            }            

            txtBoxFirstName.Clear();
            txtBoxFirstName.SendKeys(nameToBeUpdated);
            txtBoxCurrentPassword.SendKeys(password);
            txtBoxCurrentPassword.SendKeys(Keys.Enter);


            return new MyAccountPage(driver);
        }

        public MyAccountPage VerifyProfileInformationIsUpdated()
        {
            Assert.That(txtUpdateConfirmation.Text,
                Is.EqualTo("Your personal information has been successfully updated."));

            return new MyAccountPage(driver);
        }


    }
}
