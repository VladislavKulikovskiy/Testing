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



        [FindsBy(How = How.ClassName, Using = "header")]
        private IWebElement headerError;

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

        [FindsBy(How = How.Id, Using = "segments0.travelDate.errors")]
        private IWebElement firstDate;

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

        public SelectPage(IWebDriver driver, WebDriverWait Pause)
        {
            this.driver = driver;
            this.pause = Pause;
            PageFactory.InitElements(driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public string getHeaderErrorMessage()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(headerError));
            return headerError.Text;
        }

        public string getErrorMessage()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(errorMessageDate));
            return errorMessageDate.Text;
        }

        public string getErrorMessageAboutPassengerAge()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(errorMessagePassengerAge));
            return errorMessagePassengerAge.Text;
        }

        public void ClickOnTravelDate()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(travelDate));
            travelDate.Click();
            travelDate.Clear();
        }

        public void SetTravelDate(string date)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(travelDate));
            travelDate.SendKeys(date);
        }

        public void ClickOnBackTravelDate()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(backDate));
            backDate.Click();
            backDate.Clear();
        }

        public void SetTravelBackDate(string date)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(backDate));
            backDate.SendKeys(date);
        }

        public void ClickOnOrigin()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(origin));
            origin.Click();
            origin.Clear();
        }

        public void SetOrigin(string point)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(origin));
            origin.SendKeys(point);
        }

        public void ClickOnDestination()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(destination));
            destination.Click();
            destination.Clear();
        }

        public void SetDestination(string point)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(destination));
            destination.SendKeys(point);
        }

        public void ClickOnSubmitButton()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(submitBtn));
            submitBtn.Click();
        }

        public void ClickOnPassengerAge()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(passengerAge));
            passengerAge.Click();
        }

        public void SetPassengerAge(int index)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(passengerAge));
            var selectelement = new SelectElement(passengerAge);
            selectelement.SelectByIndex(index);
        }

        public string getErrorOrigin()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(fromError));
            return fromError.Text;
        }

        public string getErrorDestination()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(destinationError));
            return destinationError.Text;
        }

        public void ClickOnOriginTravelTime()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(originTravelTime));
            originTravelTime.Click();
        }

        public void SetOriginalTravleTime(int index)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(originTravelTime));
            var selectelement = new SelectElement(originTravelTime);
            selectelement.SelectByIndex(index);
        }

        public void ClickOnDestinationTravelTime()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(destinationTravelTime));
            destinationTravelTime.Click();
        }

        public void SetdestinationTravleTime(int index)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(destinationTravelTime));
            var selectelement = new SelectElement(destinationTravelTime);
            selectelement.SelectByIndex(index);
        }

        public string getErrorMessageNotFound()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(errorNotFound));
            return errorNotFound.Text;
        }


        //(pause.Until(ExpectedConditions.ElementToBeClickable(firstDate{
            
        public string getErrorFirstDate()
        {

           pause.Until(ExpectedConditions.ElementToBeClickable(firstDate));
           return firstDate.Text;

        }
    }
}
