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
        public void destinationNotPassed()
        {
            steps.StartSearch();
            steps.GoToSelectPage();
            steps.ClickOnSearchButton();

            Assert.AreEqual("Arrival city/airport is required.", steps.GetErrorMeassageDestination());
        }


        [Test]
        public void returnDateLessDepartDate()
        {
            string firstDate = Utils.Utils.getFutureDate(10);
            string secondDate = Utils.Utils.getFutureDate(5);

            steps.StartSearch();
            steps.GoToSelectPage();

            steps.SearchPageSetOriginDate(firstDate);
            steps.SearchPageSetDestinationDate(secondDate);
            steps.ClickOnSearchButton();

            Assert.AreEqual("Please check the date you entered.", steps.GetErrorMeassage());
        }

        [Test]
        public void childrenPassenger()
        {
            steps.StartSearch();
            steps.GoToSelectPage();

            steps.ClickOnPassengerType(2);
            steps.ClickOnSearchButton();

            Assert.AreEqual("Call to book a minor (age 5-15) traveling alone.", steps.GetErrorMeassageAboutPassengeraAge());
        }

        [Test]
        public void originAndDestinationTheSamePlace()
        {
            steps.StartSearch();
            steps.GoToSelectPage();

            steps.SearchPageSetOrigin("MIA");
            steps.SearchPageSetDestination("MIA");
            steps.ClickOnSearchButton();

            Assert.AreEqual("Departure and arrival cities must be different.", steps.GetErrorMeassageFrom());
            Assert.AreEqual("Departure and arrival cities must be different.", steps.GetErrorMeassageDestination());
            Assert.AreEqual(steps.GetErrorMeassageFrom(), steps.GetErrorMeassageDestination());
        }


        [Test]
        public void wayNotExist()
        {
            string firstDate = Utils.Utils.getFutureDate(0);

            steps.StartSearch();
            steps.GoToSelectPage();

            steps.SearchPageSetOrigin("MHP");
            steps.SearchPageSetOriginDate(firstDate);
            steps.SetOriginalTravelTime(1);
            steps.SearchPageSetDestination("BLI");
            steps.SearchPageSetDestinationDate(firstDate);
            steps.SetDestinationTravelTime(1);
            steps.ClickOnSearchButton();

            Assert.AreEqual("We didn't find a match. Please choose different search options.", steps.GetErrorMeassageNotFound());
        }

        [Test]
        public void wrongDestination()
        {
            steps.StartSearch();
            steps.GoToSelectPage();
            steps.SearchPageSetDestination("VVV");
            steps.ClickOnSearchButton();

            Assert.AreEqual("We couldn't find the city/airport you entered.", steps.GetErrorMeassageDestination());
        }

        [Test]
        public void hotelsToFamily()
        {
            steps.StartSearch();
            steps.GoToHotelsPage();

            steps.SetDestinationPlace("Majorca, Spain");
            steps.makeAvailable();
            steps.SetNumOFAdults(1);
            steps.SetNumOFChildren(1);
            steps.SearchButtonClick();
            steps.SetStartDate();
            steps.SearchButtonClick();

            Assert.True(steps.getTotalPrice().Contains("Цена за 2 взрослых и 1 ребенка на 1 ночь"));
        }

        [Test]
        public void pastDate()
        {
            steps.StartSearch();
            steps.GoToSelectPage();

            string firstDate = Utils.Utils.getFutureDate(-5);
            steps.SearchPageSetOriginDate(firstDate);
            steps.ClickOnSearchButton();

            Assert.AreEqual("Please check the date you entered.", steps.getFirstDateError());
        }

        [Test]
        public void businessTrip()
        {
            steps.StartSearch();
            steps.GoToHotelsPage();
            steps.SetDestinationPlace("Majorca, Spain");
            steps.makeAvailable();
            steps.TravelForWorkClick();
            steps.SearchButtonClick();

            Assert.AreEqual("Популярно для деловых поездок", steps.getWorkInfo());
        }

        [Test]
        public void dateInLongFuture()
        {
            string firstDate = Utils.Utils.getFutureDate(365);

            steps.StartSearch();
            steps.GoToSelectPage();
            steps.SearchPageSetDestinationDate(firstDate);
            steps.ClickOnSearchButton();

            Assert.IsTrue(steps.GetErrorMeassage().Contains("You can book this date beginning"));
        }


    }
}
