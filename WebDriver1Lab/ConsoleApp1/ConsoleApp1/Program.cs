using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace ConsoleApp1
{
    [TestFixture]
    class Program
    {

        static void Main(string[] args)
        {
            //var driver = new FirefoxDriver();
            //Actions builder = new Actions(driver);

            //driver.Navigate().GoToUrl("https://www.bookaahotels.com/index.html?aid=366304&label=aa-homepage-nav&lang=en-us");
            //IWebElement element1 = driver.FindElement(By.Id("ss"));
            //element1.Click();
            //element1.SendKeys("Majorca, Spain");
            //IWebElement element2 = driver.FindElement(By.ClassName("sb-searchbox__button"));
            //element2.Click();
            //Thread.Sleep(4000);

            //IWebElement element3 = driver.FindElement(By.ClassName("sb-date-field__display"));
            //element3.Click();
            //IWebElement element4 = driver.FindElement(By.ClassName("c2-day-s-today"));
            //element4.Click();

        }


        [Test]
        public static void Sel()
        {
            var driver = new FirefoxDriver();
            Actions builder = new Actions(driver);

            driver.Navigate().GoToUrl("https://www.aa.com/");

            IWebElement element1 = driver.FindElement(By.Id("plan-travel-expander"));
            element1.Click();

            Thread.Sleep(2000);
            IWebElement element2 = driver.FindElement(By.LinkText("Flights"));
            element2.Click();

            Thread.Sleep(2000);
            IWebElement element3 = driver.FindElement(By.Id("segments0.travelDate"));
            element3.Click();
            element3.Clear();
            element3.SendKeys("11/11/2018");

            Thread.Sleep(2000);
            IWebElement element4 = driver.FindElement(By.Id("flightSearchSubmitBtn"));
            element4.Click();
        }
    }
}
