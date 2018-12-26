using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace ConsoleApp1
{
    class MainPage
    {
        private IWebDriver driver;
        private WebDriverWait pause;

        [FindsBy(How = How.Id , Using = "plan-travel-expander")]
        private IWebElement planTravelExpander;

        [FindsBy(How = How.LinkText,Using = "Flights")]
        private IWebElement listElementFlights;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            pause = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public SelectPage goToSelectPage()
        {
            planTravelExpander.Click();
            Thread.Sleep(2000);
            listElementFlights.Click();

            return new SelectPage(driver);
        }
    }
}