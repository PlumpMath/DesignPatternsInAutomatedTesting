using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsInAutomatedTesting.FacadeDesignPattern.Bing.Pages.MainPage
{
    public class MainPageValidator : BasePageValidator<MainPageElementMap>
    {
        public void ValidateResultCount(string expectedCount)
        {
            Assert.AreEqual(expectedCount, this.Map.ResultCount.Text);
        }
    }
}
