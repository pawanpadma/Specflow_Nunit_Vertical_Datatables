using CT_Tech_Test.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CT_Tech_Test.StepDefinations
{
    [Binding]
    public class NewWindowSearchSteps

    {
        public HomePage home = new HomePage();
        public NewWindows window = new NewWindows();

        [When(@"I enter ""(.*)"" in Search box")]
        public void WhenIEnterInSearchBox(string Searchtext)
        {
            window.NewWinsearch(Searchtext);
        }

        [When(@"click on Search button")]
        public void WhenClickOnSearchButton()
        {
            window.Clicksearch();
        }

        [Then(@"""(.*)"" should be displayed in the result")]
        public void ThenShouldBeDisplayedInTheResult(string text)
        {
            Assert.IsTrue(window.Searchresult(text), "search result is not displayed");
        }
    }
}