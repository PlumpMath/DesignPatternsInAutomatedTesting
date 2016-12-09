using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsInAutomatedTesting.AdvancedPageObjectPattern.Bing.Pages.MainPage
{
    public class BingMainPageValidator : BasePageValidator<BingMainPageElementMap>
    {
        public void AutomateThePlanetExist()
        {
            Assert.IsTrue(this.Map.ResultLink.Displayed, "Automate The Planet hyperlink is not displayed");
        }
    }
}
