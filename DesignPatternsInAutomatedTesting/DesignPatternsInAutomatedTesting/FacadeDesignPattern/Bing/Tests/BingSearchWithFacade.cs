using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsInAutomatedTesting.FacadeDesignPattern.Bing.Tests
{
    [TestClass]
    public class BingSearchWithFacade
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
        public void FacadeSearchTextInBing_AutomateThePlanet()
        {
            string keyword = "Automate The Planet";
            string expectedCount = "2.760.000 RESULTS";
            new FacadeBingSearch().BingSearch(keyword, expectedCount);
        }

        [TestMethod]
        public void FacadeSearchTextInBing_QualityAssurance()
        {
            string keyword = "Quality Assurance";
            string expectedCount = "13.100.000 RESULTS";
            new FacadeBingSearch().BingSearch(keyword, expectedCount);
        }
    }
}
