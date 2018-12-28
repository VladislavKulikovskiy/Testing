using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ConsoleAppX.Driver
{
    class Driver
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;

        private Driver() { }

        private static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new FirefoxDriver();
                driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(150);
                driver.Manage().Window.Maximize();
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));

            }

            return driver;
        }

        public static void CloseBrouser()
        {
            driver.Quit();
            driver = null;
        }

        public static WebDriverWait GetWait()
        {
            return wait;
        }

    }
}
