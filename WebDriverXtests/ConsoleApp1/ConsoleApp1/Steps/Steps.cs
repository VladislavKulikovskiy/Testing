using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ConsoleAppX.Steps
{
    class Steps
    {
        IWebDriver driver;
        private OpenQA.Selenium.Support.UI.WebDriverWait pause;

        public void InitBrowser()
        {
            driver = Driver.Driver.GetInstance();
            pause = Driver.Driver.GetWait();
        }

        public void CloseBrowser()
        {
            Driver.Driver.CloseBrouser();
        }

        public void StartSearch()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
        }

        public void GoToSelectPage()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.goToSelectPage();
        }

        public void SearchPageSetOriginDate(string firstDate)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            selectPage.ClickOnTravelDate();
            selectPage.SetTravelDate(firstDate);
        }

        public void SearchPageSetDestinationDate(string secondDate)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            selectPage.ClickOnBackTravelDate();
            selectPage.SetTravelBackDate(secondDate);
        }

        public void ClickOnSearchButton()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            selectPage.ClickOnSubmitButton();
        }

        public string GetErrorMeassage()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            return selectPage.getErrorMessage();
        }

        public string GetErrorMeassageAboutPassengeraAge()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            return selectPage.getErrorMessageAboutPassengerAge();
        }

        public void ClickOnPassengerType(int index)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            selectPage.ClickOnPassengerAge();
            selectPage.SetPassengerAge(index);
        }

        public void SetOriginalTravelTime(int index)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            selectPage.ClickOnOriginTravelTime();
            selectPage.SetOriginalTravleTime(index);
        }

        public void SetDestinationTravelTime(int index)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            selectPage.ClickOnDestinationTravelTime();
            selectPage.SetdestinationTravleTime(index);
        }

        public void SearchPageSetOrigin(string firstPlace)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            selectPage.ClickOnOrigin();
            selectPage.SetOrigin(firstPlace);
        }

        public void SearchPageSetDestination(string secondPlace)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            selectPage.ClickOnDestination();
            selectPage.SetDestination(secondPlace);
        }

        public string GetErrorMeassageFrom()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            return selectPage.getErrorOrigin();
        }

        public string GetErrorMeassageDestination()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            return selectPage.getErrorDestination();
        }

        public string GetErrorMeassageNotFound()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            return selectPage.getErrorMessageNotFound();
        }

        public void GoToHotelsPage()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.goToHotelsPage();
        }

        public void SetDestinationPlace(string place)
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            hotelPage.clickOnDestinationPlace();
            hotelPage.setDestinationPlace(place);
        }

        public void SetNumOFAdults(int index)
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            hotelPage.clickOnNumOfAdults();
            hotelPage.SetNumOfAdults(index);
        }

        public void makeAvailable()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            hotelPage.clickOnHat();
        }

        public void SetNumOFChildren(int index)
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            hotelPage.clickOnNumOfChildren();
            hotelPage.SetNumOfChildren(index);
        }

        public void SetStartDate()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            hotelPage.ClickOnDateField();
            //Thread.Sleep(1000);
            hotelPage.AAAAAAAAAAA();
            hotelPage.ClickOnDateField();
            hotelPage.ClickOnInnerDay();
        }

        public void SearchButtonClick()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            hotelPage.ClickOnSearchButton();
        }

        public string getTotalPrice()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            return hotelPage.getTotalPrice();
        }

        public string getFirstDateError()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver, pause);
            return selectPage.getErrorFirstDate();
        }

        public void TravelForWorkClick()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            hotelPage.clickTravelForWork();
        }


        public string getWorkInfo()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver, pause);
            return hotelPage.getWorkInfo();
        }


    }
}
