using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ConsoleApp1.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.Driver.GetInstance();
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

        public void SearchPageSetOrigin(string firstDate)
        {
            Pages.SelectPage selectPage = new Pages.SelectPage(driver);
            selectPage.ClickOnTravelDate();
            selectPage.SetTravelDate(firstDate);
        }

        public void SearchPageSetDestination(string secondDate)
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
    }
}
