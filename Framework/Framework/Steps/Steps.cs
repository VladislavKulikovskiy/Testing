using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.Steps
{
    class Steps
    {
        private IWebDriver driver;
        private double rubleValue, euroValue;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
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
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnTravelDate();
            selectPage.SetTravelDate(firstDate);
        }

        public void SearchPageSetDestinationDate(string secondDate)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnBackTravelDate();
            selectPage.SetTravelBackDate(secondDate);
        }

        public void ClickOnSearchButton()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnSubmitButton();
        }

        public string GetErrorMeassage()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            return selectPage.getErrorMessage();
        }

        public string GetErrorMeassageAboutPassengeraAge()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            return selectPage.getErrorMessageAboutPassengerAge();
        }

        public void ClickOnPassengerType(int index)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnPassengerAge();
            selectPage.SetPassengerAge(index);
        }

        public void SetOriginalTravelTime(int index)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnOriginTravelTime();
            selectPage.SetOriginalTravleTime(index);
        }

        public void SetDestinationTravelTime(int index)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnDestinationTravelTime();
            selectPage.SetdestinationTravleTime(index);
        }

        public void SearchPageSetOrigin(string firstPlace)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnOrigin();
            selectPage.SetOrigin(firstPlace);
        }

        public void SearchPageSetDestination(string secondPlace)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnDestination();
            selectPage.SetDestination(secondPlace);
        }

        public string GetErrorMeassageFrom()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            return selectPage.getErrorOrigin();
        }

        public string GetErrorMeassageDestination()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            return selectPage.getErrorDestination();
        }

        public string GetErrorMeassageNotFound()
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            return selectPage.getErrorMessageNotFound();
        }

        public void GoToHotelsPage()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.goToHotelsPage();
        }

        public void SetDestinationPlace(string place)
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver);
            hotelPage.clickOnDestinationPlace();
            hotelPage.setDestinationPlace(place);
        }

        public void SetNumOFAdults(int index)
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver);
            hotelPage.clickOnNumOfAdults();
            hotelPage.SetNumOfAdults(index);
        }

        public void makeAvailable()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver);
            hotelPage.clickOnHat();
        }

        public void SetNumOFChildren(int index)
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver);
            hotelPage.clickOnNumOfChildren();
            hotelPage.SetNumOfChildren(index);
        }

        public void SetStartDate()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver);
            hotelPage.ClickOnDateField();
            Thread.Sleep(1000);
            hotelPage.AAAAAAAAAAA();
            hotelPage.ClickOnDateField();
            hotelPage.ClickOnInnerDay();
        }

        public void SearchButtonClick()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver);
            hotelPage.ClickOnSearchButton();
        }

        public string getTotalPrice()
        {
            Pages.HotelsPage hotelPage = new Pages.HotelsPage(driver);
            return hotelPage.getTotalPrice();
        }
    }
}
