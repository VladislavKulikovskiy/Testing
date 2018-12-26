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

namespace ConsoleAppX.Pages
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

        [FindsBy(How = How.Id, Using = "passengers0.passengerType")]
        private IWebElement passengerAge;

        [FindsBy(How = How.Id, Using = "segments1.travelDate.errors")]
        private IWebElement errorMessageDate;

        [FindsBy(How = How.Id, Using = "passengers0.passengerType.errors")]
        private IWebElement errorMessagePassengerAge;

        [FindsBy(How = How.Id, Using = "segments0.origin.errors")]
        private IWebElement fromError;

        [FindsBy(How = How.Id, Using = "segments0.destination.errors")]
        private IWebElement destinationError;

        [FindsBy(How = How.Id, Using = "segments0.travelTime")]
        private IWebElement originTravelTime;

        [FindsBy(How = How.Id, Using = "segments1.travelTime")]
        private IWebElement destinationTravelTime;

        [FindsBy(How = How.Id, Using = "err-message-ERRCODE309")]
        private IWebElement errorNotFound;

        [FindsBy(How = How.ClassName, Using = "no-margin")]
        private IWebElement errorNotFound2;


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
            return errorMessageDate.Text;
        }

        public string getErrorMessageAboutPassengerAge()
        {
            return errorMessagePassengerAge.Text;
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

        public void ClickOnPassengerAge()
        {
            passengerAge.Click();
        }

        public void SetPassengerAge(int index)
        {
            var selectelement = new SelectElement(passengerAge);
            selectelement.SelectByIndex(index);
        }

        public string getErrorOrigin()
        {
            return fromError.Text;
        }

        public string getErrorDestination()
        {
            return destinationError.Text;
        }

        public void ClickOnOriginTravelTime()
        {
            originTravelTime.Click();
        }

        public void SetOriginalTravleTime(int index)
        {
            var selectelement = new SelectElement(originTravelTime);
            selectelement.SelectByIndex(index);
        }

        public void ClickOnDestinationTravelTime()
        {
            destinationTravelTime.Click();
        }

        public void SetdestinationTravleTime(int index)
        {
            var selectelement = new SelectElement(destinationTravelTime);
            selectelement.SelectByIndex(index);
        }

        public string getErrorMessageNotFound()
        {
            return errorNotFound.Text;
        }







    }
}
