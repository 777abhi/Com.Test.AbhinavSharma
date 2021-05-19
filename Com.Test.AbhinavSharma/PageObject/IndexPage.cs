using Com.Test.AbhinavSharma.Base;
using Com.Test.AbhinavSharma.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Com.Test.AbhinavSharma.PageObject
{
    public class IndexPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign in')]")]
        private IWebElement linkSignIn;

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        private IWebElement txtBoxEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        private IWebElement txtBoxPassword;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'My personal information')]")]
        private IWebElement linkMyPersonalInformation;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Order history and details')]")]
        private IWebElement linkOrderHistoryAndDetails;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"header\"]/div[2]/div/div/nav/div[1]/a")]
        private IWebElement linkMyAccountSection;

        //Display Order Reference
        
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]")]
        private IWebElement txtOrderReferenceNumber;

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[2]")]
        private IWebElement txtOrderDate;
          
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[3]")]
        private IWebElement txtOrderTotalPrice;
          
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[4]")]
        private IWebElement txtOrderPaymentType;
           
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[5]")]
        private IWebElement txtOrderStatus;


        public Settings _settings;
        public IndexPage(Settings settings) => _settings = settings;

        public IndexPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IndexPage verifyPlacedOrderDetails()
        {

            GenericHelper.OutputFormattedAs("", "Expected Reference Number"
                , txtOrderReferenceNumber.Text);
            GenericHelper.OutputFormattedAs("", "Expected Order Date"
                , txtOrderDate.Text);
            GenericHelper.OutputFormattedAs("", "Expected Total Price"
                , txtOrderTotalPrice.Text);
            GenericHelper.OutputFormattedAs("", "Expected Payment Type"
                , txtOrderPaymentType.Text);
            GenericHelper.OutputFormattedAs("", "Expected Order Status"
                , txtOrderStatus.Text);

            //Assert
            Assert.That(txtOrderReferenceNumber.Text.Length, Is.EqualTo(9));
            Assert.That(txtOrderDate.Text, Is.EqualTo(DateTime.Today.ToString("MM/dd/yyyy")));
            Assert.That(txtOrderTotalPrice.Text, Is.EqualTo("$18.51"));
            //Assert.That(txtOrderPaymentType.Text, Is.EqualTo("Bank wire"));
            Assert.That(txtOrderStatus.Text, Is.EqualTo("On backorder"));



            return new IndexPage(driver);
        }

        public IndexPage goToPage(string url) {
            driver.Navigate().GoToUrl(url);
            //Assert  //TODO
            return new IndexPage(driver);

        }

        public IndexPage navigateToMyAccountSection()
        {
            linkMyAccountSection.Click();
            return new IndexPage(driver);
        }

        public IndexPage performLogin(
              string userName
            , string password)
        {
            linkSignIn.Click();
            txtBoxEmail.SendKeys(userName);
            txtBoxPassword.SendKeys(password);
            txtBoxPassword.SendKeys(Keys.Enter);
            //Assert  //TODO
            return new IndexPage(driver);
        }
        public IndexPage navigateToPersonalInformationInMyAccountSection()
        {
            linkMyPersonalInformation.Click();
            //Assert  //TODO
            return new IndexPage(driver);
        }
        public IndexPage navigateToOrderHistoryAndDetailsInMyAccountSection()
        {
            linkOrderHistoryAndDetails.Click();
            //Assert  //TODO
            return new IndexPage(driver);
        }



    }
}
