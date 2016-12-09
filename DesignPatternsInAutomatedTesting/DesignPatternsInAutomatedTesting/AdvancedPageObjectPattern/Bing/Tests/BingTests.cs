using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsInAutomatedTesting.AdvancedPageObjectPattern.Bing.Pages.MainPage;

namespace DesignPatternsInAutomatedTesting.AdvancedPageObjectPattern.Bing.Tests
{
    [TestClass]
    public class BingTests
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
        public void SearchTextInBing_Three()
        {
            BingMainPage bingMainPage = new BingMainPage();
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.Validate().AutomateThePlanetExist();
        }
    }
}
