using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    class HotelsPage
    {
        private const string BASE_URL = "https://www.bookaahotels.com/index.html?aid=366304&label=aa-homepage-nav&lang=en-us";
        private IWebDriver driver;
        private WebDriverWait pause;

        [FindsBy(How = How.Id, Using = "affiliate_top")]
        private IWebElement hat;

        [FindsBy(How = How.Id, Using = "ss")]
        private IWebElement destinationPlace;

        [FindsBy(How = How.Id, Using = "group_adults")]
        private IWebElement numOfAdults;

        [FindsBy(How = How.Id, Using = "group_children")]
        private IWebElement numOfChildren;

        [FindsBy(How = How.ClassName, Using = "sb-searchbox__button")]
        private IWebElement searchButton;

        [FindsBy(How = How.ClassName, Using = "sb-date-field__display")]
        private IWebElement dateField;

        [FindsBy(How = How.ClassName, Using = "c2-day-s-today")]
        private IWebElement innerDay;

        [FindsBy(How = How.ClassName, Using = "close_inspire_filter_block")]
        private IWebElement fuckinghelperPLSDIE;

        [FindsBy(How = How.ClassName, Using = "sb-searchbox__button")]
        private IWebElement srchButton;

        [FindsBy(How = How.ClassName, Using = "totalPrice")]
        private IWebElement totalPrice;



        public HotelsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void clickOnHat()
        {
            hat.Click();
        }

        public void clickOnDestinationPlace()
        {
            destinationPlace.Click();
        }

        public void setDestinationPlace(string place)
        {
            destinationPlace.SendKeys(place);
        }

        public void clickOnNumOfAdults()
        {
            numOfAdults.Click();
        }

        public void SetNumOfAdults(int index)
        {
            var selectelement = new SelectElement(numOfAdults);
            selectelement.SelectByIndex(index);
        }

        public void clickOnNumOfChildren()
        {
            numOfAdults.Click();
        }

        public void SetNumOfChildren(int index)
        {
            var selectelement = new SelectElement(numOfChildren);
            selectelement.SelectByIndex(index);
        }

        public void ClickOnSearchButton()
        {
            searchButton.Click();
        }

        public void ClickOnDateField()
        {
            dateField.Click();
        }

        public void ClickOnInnerDay()
        {
            innerDay.Click();
        }

        public void AAAAAAAAAAA()
        {
            fuckinghelperPLSDIE.Click();

        }

        public string getTotalPrice()
        {
            return totalPrice.Text;
        }

    }
}
