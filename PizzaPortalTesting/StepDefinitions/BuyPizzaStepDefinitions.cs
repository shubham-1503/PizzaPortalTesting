using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace PizzaPortalTesting.StepDefinitions
{
    [Binding]
    public class BuyPizzaStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public BuyPizzaStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\shubham.pawar\\Downloads\\chromedriver_win32");
        [Given(@"I have navigated to Website")]
        public void GivenIHaveNavigatedToWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://localhost:7299/");
        }

        [When(@"I click on Buy Now Button")]
        public void WhenIClickOnBuyNowButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var BuyNowButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div[2]/div[2]/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", BuyNowButton);
        }

        [Then(@"I am redirected to cart page with that specific pizza")]
        public void ThenIAmRedirectedToCartPageWithThatSpecificPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

    
        [When(@"I click on continue shopping")]
        public void WhenIClickOnContinueShopping()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var ContinueShopppingButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/a[1]"));
            chromeDriver.ExecuteScript("arguments[0].click();", ContinueShopppingButton);
        }

        [Then(@"Home page gets opened \(for extra pizza\)")]
        public void ThenHomePageGetsOpenedForExtraPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

        [When(@"I click on Buy Now Button for different pizza")]
        public void WhenIClickOnBuyNowButtonForDifferentPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var ContinueShopppingButton2 = chromeDriver.FindElement(By.XPath("/html/body/div/main/div[2]/div[1]/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", ContinueShopppingButton2);

        }

        [Then(@"I am redirected to cart page with that new pizza added")]
        public void ThenIAmRedirectedToCartPageWithThatNewPizzaAdded()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));

        }

        [When(@"I click on Checkout")]
        public void WhenIClickOnCheckout()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var CheckoutButton = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/a[2]"));
            chromeDriver.ExecuteScript("arguments[0].click();", CheckoutButton);

        }

        [Then(@"Checkout page gets opened")]
        public void ThenCheckoutPageGetsOpened()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));

        }
    }
}
