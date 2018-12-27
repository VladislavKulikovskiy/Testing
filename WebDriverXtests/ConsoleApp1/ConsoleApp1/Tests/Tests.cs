using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppX.Tests
{
    [TestFixture]
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        //[TearDown]
        //public void Cleanup()
        //{
        //    steps.CloseBrowser();
        //}


        [Test]
        public void SecondTest()
        {
            string firstDate = Utils.Utils.getFutureDate(10);
            string secondDate = Utils.Utils.getFutureDate(5);

            steps.StartSearch();
            steps.GoToSelectPage();

            steps.SearchPageSetOriginDate(firstDate);
            steps.SearchPageSetDestinationDate(secondDate);
            steps.ClickOnSearchButton();
            Thread.Sleep(5000);
            Assert.AreEqual("Please check the date you entered.", steps.GetErrorMeassage());
        }

        [Test]
        public void ThirdTest()
        {
            string firstDate = Utils.Utils.getFutureDate(10);
            string secondDate = Utils.Utils.getFutureDate(5);

            steps.StartSearch();
            steps.GoToSelectPage();

            //steps.SearchPageSetOrigin(firstDate);
            //steps.SearchPageSetDestination(secondDate);

            steps.ClickOnPassengerType(2);
            Thread.Sleep(5000);
            steps.ClickOnSearchButton();
            Thread.Sleep(5000);
            Assert.AreEqual("Call to book a minor (age 5-15) traveling alone.", steps.GetErrorMeassageAboutPassengeraAge());
        }

        [Test]
        public void FourTest()
        {
            steps.StartSearch();
            steps.GoToSelectPage();

            steps.SearchPageSetOrigin("MIA");
            Thread.Sleep(5000);
            steps.SearchPageSetDestination("MIA");
            Thread.Sleep(5000);
            steps.ClickOnSearchButton();
            Thread.Sleep(5000);

            Assert.AreEqual("Departure and arrival cities must be different.", steps.GetErrorMeassageFrom());
            Assert.AreEqual("Departure and arrival cities must be different.", steps.GetErrorMeassageDestination());
            Assert.AreEqual(steps.GetErrorMeassageFrom(), steps.GetErrorMeassageDestination());
            //Assert.AreEqual("Call to book a minor (age 5-15) traveling alone.", steps.GetErrorMeassageAboutPassengeraAge());
        }


        [Test]
        public void FiveTest()
        {
            string firstDate = Utils.Utils.getFutureDate(0);

            steps.StartSearch();
            steps.GoToSelectPage();

            steps.SearchPageSetOrigin("MHP");
            Thread.Sleep(1000);
            steps.SearchPageSetOriginDate(firstDate);
            Thread.Sleep(1000);
            steps.SetOriginalTravelTime(1);
            Thread.Sleep(1000);
            steps.SearchPageSetDestination("BLI");
            Thread.Sleep(1000);
            steps.SearchPageSetDestinationDate(firstDate);
            Thread.Sleep(1000);
            steps.SetDestinationTravelTime(1);
            Thread.Sleep(1000);
            steps.ClickOnSearchButton();
            Thread.Sleep(5000);

            Assert.AreEqual("We didn't find a match. Please choose different search options.", steps.GetErrorMeassageNotFound());
        }

        //[Test]
        //public void SevenTest()
        //{
        //    steps.StartSearch();
        //    steps.GoToHotelsPage();

        //    Thread.Sleep(1000);

        //    steps.SetDestinationPlace("Majorca, Spain");
        //    Thread.Sleep(1000);
        //    steps.makeAvailable();
        //    Thread.Sleep(1000);
        //    steps.SetNumOFAdults(1);
        //    Thread.Sleep(1000);
        //    steps.SetNumOFChildren(1);
        //    Thread.Sleep(1000);
        //    steps.SearchButtonClick();
        //    Thread.Sleep(3000);

        //    steps.SetStartDate();
        //    Thread.Sleep(1000);
        //    steps.SearchButtonClick();


        //    Assert.True(steps.getTotalPrice().Contains("Цена за 2 взрослых и 1 ребенка на 1 ночь"));

        //}

    }
}
