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
    class SelectPage
    {
        private const string BASE_URL = "https://www.aa.com/booking/find-flights?tripType=roundTrip";
        private IWebDriver driver;
        private WebDriverWait pause;

        [FindsBy(How = How.Id, Using = "segments0.travelDate")]
        private IWebElement travelDate;

        [FindsBy(How = How.Id, Using = "segments1.travelDate")]
        private IWebElement backDate;

        [FindsBy(How = How.Id, Using = "segments0.origin")]
        private IWebElement origin;

        [FindsBy(How = How.Id, Using = "segments0.destination")]
        private IWebElement destination;

        [FindsBy(How = How.Id, Using = "flightSearchSubmitBtn")]
        private IWebElement submitBtn;



        [FindsBy(How = How.Id, Using = "segments1.travelDate.errors")]
        private IWebElement errorMessage;


        public SelectPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public string getErrorMessage()
        {
            return errorMessage.Text;
        }

        public void ClickOnTravelDate()
        {
            travelDate.Click();
            travelDate.Clear();
        }

        public void SetTravelDate(string date)
        {
            travelDate.SendKeys(date);
        }

        public void ClickOnBackTravelDate()
        {
            backDate.Click();
            backDate.Clear();
        }

        public void SetTravelBackDate(string date)
        {
            backDate.SendKeys(date);
        }

        public void ClickOnOrigin()
        {
            origin.Click();
            origin.Clear();
        }

        public void SetOrigin(string point)
        {
            origin.SendKeys(point);
        }

        public void ClickOnDestination()
        {
            destination.Click();
            destination.Clear();
        }

        public void SetDestination(string point)
        {
            destination.SendKeys(point);
        }

        public void ClickOnSubmitButton()
        {
            submitBtn.Click();
        }



        //public void SelectFlyPar(string date)
        //{
        //    travelDate.Click();
        //    travelDate.Clear();
        //    travelDate.SendKeys(date);
        //    Thread.Sleep(2000);

        //    origin.Click();
        //    origin.Clear();
        //    origin.SendKeys("BCN");
        //    Thread.Sleep(2000);

        //    destination.Click();
        //    destination.Clear();
        //    destination.SendKeys("MIA");
        //    Thread.Sleep(2000);

        //    submitBtn.Click();
        //}





    }
}
