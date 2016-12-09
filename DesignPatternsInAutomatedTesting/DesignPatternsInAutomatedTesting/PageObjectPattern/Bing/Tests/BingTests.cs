using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using DesignPatternsInAutomatedTesting.PageObjectPattern.Bing.Pages;
using DesignPatternsInAutomatedTesting.PageObjectPattern.Bing.Pages.POP;

namespace DesignPatternsInAutomatedTesting.PageObjectPattern.Bing.Tests
{
    [TestClass]
    public class BingTests
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void SearchTextInBing_First()
        {
            BingMainPage bingMainPage = new BingMainPage(this.Driver);
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.ValidateResultsCount(".000 RESULTS");
        }

        [TestMethod]
        public void SearchTextInBing_Second()
        {
            BingMainPage2 bingMainPage = new BingMainPage2(this.Driver);
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.Validate().ResultsCount(".000 RESULTS");
        }
    }
}
