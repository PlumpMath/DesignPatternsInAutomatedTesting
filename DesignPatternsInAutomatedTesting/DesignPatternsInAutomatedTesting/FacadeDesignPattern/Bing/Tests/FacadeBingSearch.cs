using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsInAutomatedTesting.FacadeDesignPattern.Bing.Pages.MainPage;

namespace DesignPatternsInAutomatedTesting.FacadeDesignPattern.Bing.Tests
{
    public class FacadeBingSearch
    {
        private MainPage mainPage;

        public MainPage MainPage
        {
            get
            {
                if(mainPage==null)
                {
                    mainPage = new MainPage();
                }
                return mainPage;
            }
        }

        public void BingSearch (string keyword, string expectedCount)
        {
            this.MainPage.Navigate();
            this.MainPage.Search(keyword);
            this.MainPage.Validate().ValidateResultCount(expectedCount);
        }
    }
}
