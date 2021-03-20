using CT_Tech_Test.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CT_Tech_Test.StepDefinations
{
    [Binding]
    public class HomeSignupSteps

    {
        public HomePage home = new HomePage();

        [Given(@"I am on Automation Testing page")]
        public void GivenIAmOnAutomationTestingPage()
        {
            home.homepagetitle();
        }

        [When(@"I enter details in volunteer signup form with out fileuploaded")]
        public void WhenIEnterDetailsInVolunteerSignupFormWithOutFileuploaded(Table table)
        {
            home.EnterFormDetails(table);
        }

        [When(@"submit the form")]
        public void WhenSubmitTheForm()
        {
            home.Submitform();
        }

        [Then(@"Verify ""(.*)"" is displayed")]
        public void ThenVerifyIsDisplayed(string error)
        {
            Assert.AreEqual(error, home.ValidateError());
        }

        [When(@"I upload a file")]
        public void WhenIUploadAFile()
        {
            home.Fileuploadonform();
        }

        [When(@"I enter firstname and lastname in the form")]
        public void WhenIEnterFirstnameAndLastnameInTheForm(Table table)
        {
            home.EnterFormDetails(table);
        }

        [When(@"I enter firstname and lastname and Country in the form")]
        public void WhenIEnterFirstnameAndLastnameAndCountryInTheForm(Table table)
        {
            home.EnterFormDetails(table);
        }

        [When(@"I enter invalid Phone")]
        public void WhenIEnterInvalidPhone(Table table)
        {
            home.EnterFormDetails(table);
        }

        [When(@"I enter email address only")]
        public void WhenIEnterEmailAddressOnly(Table table)
        {
            home.EnterFormDetails(table);
        }
    }
}