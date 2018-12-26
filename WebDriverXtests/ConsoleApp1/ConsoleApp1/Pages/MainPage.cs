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

        [FindsBy(How = How.ClassName, Using = "icon-newpage")]
        private IWebElement listElementHotels;

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

        public void goToHotelsPage()
        {
            planTravelExpander.Click();
            Thread.Sleep(2000);
            //listElementHotels.Click();
            //Thread.Sleep(5000);
            //IWebElement element = driver.FindElement(By.TagName("body"));
            //Thread.Sleep(5000);
            //element.SendKeys(OpenQA.Selenium.Keys.Control + "t");
            driver.Navigate().GoToUrl("https://www.bookaahotels.com/index.html?aid=366304&label=aa-homepage-nav&lang=en-us");
        }
    }
}