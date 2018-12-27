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

        [FindsBy(How = How.ClassName, Using = "sb-booker-type-checkbox")]
        private IWebElement travelForWork;

        [FindsBy(How = How.ClassName, Using = "icon_filtercategory_container")]
        private IWebElement workInfo;

        public HotelsPage(IWebDriver driver, WebDriverWait Pause)
        {
            this.driver = driver;
            this.pause = Pause;
            PageFactory.InitElements(driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void clickOnHat()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(hat));
            hat.Click();
        }

        public void clickOnDestinationPlace()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(destinationPlace));
            destinationPlace.Click();
        }

        public void setDestinationPlace(string place)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(destinationPlace));
            destinationPlace.SendKeys(place);
        }

        public void clickOnNumOfAdults()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(numOfAdults));
            numOfAdults.Click();
        }

        public void SetNumOfAdults(int index)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(numOfAdults));
            var selectelement = new SelectElement(numOfAdults);
            selectelement.SelectByIndex(index);
        }

        public void clickOnNumOfChildren()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(numOfAdults));
            numOfAdults.Click();
        }

        public void SetNumOfChildren(int index)
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(numOfChildren));
            var selectelement = new SelectElement(numOfChildren);
            selectelement.SelectByIndex(index);
        }

        public void ClickOnSearchButton()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(searchButton));
            searchButton.Click();
        }

        public void ClickOnDateField()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(dateField));
            dateField.Click();
        }

        public void ClickOnInnerDay()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(innerDay));
            innerDay.Click();
        }

        public void AAAAAAAAAAA()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(fuckinghelperPLSDIE));
            fuckinghelperPLSDIE.Click();

        }

        public string getTotalPrice()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(totalPrice));
            return totalPrice.Text;
        }

        public void clickTravelForWork()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(travelForWork));
            travelForWork.Click();
        }

        public string getWorkInfo()
        {
            pause.Until(ExpectedConditions.ElementToBeClickable(workInfo));
            return workInfo.Text;
        }

        
    }
}
