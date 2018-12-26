using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
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

            steps.SearchPageSetOrigin(firstDate);
            steps.SearchPageSetDestination(secondDate);
            steps.ClickOnSearchButton();
            Thread.Sleep(5000);
            Assert.AreEqual("Please check the date you entered.", steps.GetErrorMeassage());
        }

    }
}
