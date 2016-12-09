using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsInAutomatedTesting.FacadeDesignPattern.Bing.Pages.MainPage;

namespace DesignPatternsInAutomatedTesting.FacadeDesignPattern.Bing.Tests
{
    [TestClass]
    public class BingTestWithoutFacade
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void SearchTextInBing_AutomateThePlanet()
        {
            MainPage bingMainPage = new MainPage();
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.Validate().ValidateResultCount("2.760.000 RESULTS");
        }

        [TestMethod]
        public void SearchTextInBing_QualityAssurance()
        {
            MainPage bingMainPage = new MainPage();
            bingMainPage.Navigate();
            bingMainPage.Search("Quality Assurance");
            bingMainPage.Validate().ValidateResultCount("13.100.000 RESULTS");
        }
    }
}
