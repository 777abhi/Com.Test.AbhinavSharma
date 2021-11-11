using Com.Test.AbhinavSharma.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;

namespace Com.Test.AbhinavSharma.PageObject
{
    public class CategoryPage
    {

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"block_top_menu\"]/ul/li[3]/a")]
        private IWebElement linkTshirt;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/ul/li/div/div[1]/div/a[1]/img")]
        private IWebElement hoverShirt;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add to cart')]")]
        private IWebElement btnAddToCart;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a/span")]
        private IWebElement btnProceedToCheckout;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/p[2]/a[1]/span")]
        private IWebElement btnProceedToCheckoutAfterSummary;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/form/p/button/span")]
        private IWebElement btnProceedToCheckoutAfterAddress;


        [FindsBy(How = How.XPath, Using = "//input[@id='cgv']")]
        private IWebElement checkBoxTermsOfService;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"form\"]/p/button/span")]
        private IWebElement btnProceedToCheckoutAfterShipping;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"HOOK_PAYMENT\"]/div[1]/div/p/a")]
        private IWebElement btnPayByWire;

        //*[@id="cart_navigation"]/button/span        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"cart_navigation\"]/button/span")]
        private IWebElement btnConfirmMyOrder;

        public Settings _settings;
        public CategoryPage(Settings settings) => _settings = settings;

        public CategoryPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public CategoryPage navigateToTShirtCategory()
        {


            linkTshirt.Click();
            Actions action = new Actions(driver);
            action.MoveToElement(hoverShirt).Perform();
            btnAddToCart.Click();
            //Assert  //TODO
            return new CategoryPage(driver);

        }

        public CategoryPage proceedToCheckout()
        {
            btnProceedToCheckout.Click();
            btnProceedToCheckoutAfterSummary.Click();
            btnProceedToCheckoutAfterAddress.Click();
            checkBoxTermsOfService.Click();
            btnProceedToCheckoutAfterShipping.Click();
            btnPayByWire.Click();
            btnConfirmMyOrder.Click();
            return new CategoryPage(driver);

        }
    }
}
