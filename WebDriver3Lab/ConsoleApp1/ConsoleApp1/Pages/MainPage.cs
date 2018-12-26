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

namespace ConsoleApp1.Pages
{
    class MainPage
    {

        private const string BASE_URL = "https://www.aa.com/";
        private IWebDriver driver;

        [FindsBy(How = How.Id , Using = "plan-travel-expander")]
        private IWebElement planTravelExpander;

        [FindsBy(How = How.LinkText,Using = "Flights")]
        private IWebElement listElementFlights;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void goToSelectPage()
        {
            planTravelExpander.Click();
            Thread.Sleep(2000);
            listElementFlights.Click();
        }
    }
}