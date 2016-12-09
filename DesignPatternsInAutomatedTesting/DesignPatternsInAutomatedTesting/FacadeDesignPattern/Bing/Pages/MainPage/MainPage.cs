using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInAutomatedTesting.FacadeDesignPattern.Bing.Pages.MainPage
{
    public class MainPage : BasePage<MainPageElementMap, MainPageValidator>
    {
        public MainPage()
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
