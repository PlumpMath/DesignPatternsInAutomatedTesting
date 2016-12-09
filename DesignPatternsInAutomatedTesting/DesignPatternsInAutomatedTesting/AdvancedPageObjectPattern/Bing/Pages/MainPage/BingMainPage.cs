using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInAutomatedTesting.AdvancedPageObjectPattern.Bing.Pages.MainPage
{
    public class BingMainPage : BasePage<BingMainPageElementMap, BingMainPageValidator>
    {
        public BingMainPage()
            : base(@"http://www.bing.com/")
        {
        }

        public void Search(string keyword)
        {
            this.Map.SearchBox.Clear();
            this.Map.SearchBox.SendKeys(keyword);
            this.Map.GoButton.Click();
        }
    }
}
