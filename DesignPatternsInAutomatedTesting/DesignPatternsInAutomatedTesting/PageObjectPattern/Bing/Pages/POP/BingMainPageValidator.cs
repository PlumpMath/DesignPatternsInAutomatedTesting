using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsInAutomatedTesting.PageObjectPattern.Bing.Pages.POP
{
    public class BingMainPageValidator
    {
        private readonly IWebDriver browser;

        public BingMainPageValidator(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected BingMainPageElementMap Map
        {
            get
            {
                return new BingMainPageElementMap(this.browser);
            }
        }

        public void ResultsCount(string expectedCount)
        {
            Assert.IsTrue(this.Map.ResultsCountDiv.Text.Contains(expectedCount),
            "The results DIV doesn't contains the specified text.");
        }
    }
}
