using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsInAutomatedTesting.FacadeDesignPattern.Bing.Pages.MainPage
{
    public class MainPageElementMap : BasePageElementMap
    {
        public IWebElement SearchBox
        {
            get
            {
                return this.browser.FindElement(By.Id("sb_form_q"));
            }
        }

        public IWebElement GoButton
        {
            get
            {
                return this.browser.FindElement(By.Id("sb_form_go"));
            }
        }

        public IWebElement ResultCount
        {
            get
            {
                return this.browser.FindElement(By.ClassName("sb_count"));
            }
        }
    }
}
