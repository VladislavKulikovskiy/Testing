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

namespace ConsoleApp1
{
    class SelectPage
    {

        private IWebDriver driver;
        private WebDriverWait pause;

        [FindsBy(How = How.Id, Using = "segments0.travelDate")]
        private IWebElement travelDate;

        [FindsBy(How = How.Id, Using = "segments0.origin")]
        private IWebElement origin;

        [FindsBy(How = How.Id, Using = "segments0.destination")]
        private IWebElement destination;

        [FindsBy(How = How.Id, Using = "flightSearchSubmitBtn")]
        private IWebElement submitBtn;


        public SelectPage(IWebDriver driver)
        {
            this.driver = driver;
            pause = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void SelectFlyPar(string date)
        {
            travelDate.Click();
            travelDate.Clear();
            travelDate.SendKeys(date);
            Thread.Sleep(2000);

            origin.Click();
            origin.Clear();
            origin.SendKeys("BCN");
            Thread.Sleep(2000);

            destination.Click();
            destination.Clear();
            destination.SendKeys("MIA");
            Thread.Sleep(2000);

            submitBtn.Click();
        }





    }
}
