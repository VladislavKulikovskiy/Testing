using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace ConsoleAppX
{
    [TestFixture]
    class Program
    {

        static void Main(string[] args)
        {
        }
        

        //[Test]
        //public static void Sel()
        //{

        //    DateTime y = DateTime.Now;
        //    y = y.AddDays(3);
        //    string mou = y.ToString("MMM", new CultureInfo("en-US"));
        //    string day = y.Day.ToString();
        //    string mounth = y.Month.ToString();
        //    string year = y.Year.ToString();
        //    string date = mounth + "/" + day + "/" + year;

        //    string element = "date_" + mou + "-" + day;

        //    var driver = new FirefoxDriver();
        //    Actions builder = new Actions(driver);

        //    driver.Navigate().GoToUrl("https://www.aa.com/");

        //    MainPage mainPage = new MainPage(driver);
        //    SelectPage selPage = mainPage.goToSelectPage();

        //    selPage.SelectFlyPar(date);

        //    Thread.Sleep(10000);
        //    IWebElement z = driver.FindElement(By.Id("date_Nov-28"));
        //    Assert.IsNotNull(z);
                                            
        //}
    }
}
