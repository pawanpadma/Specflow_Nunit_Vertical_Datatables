using CT_Tech_Test.PageObjects;
using CT_Tech_Test.Commons;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CT_Tech_Test.Commons
{
    [Binding]
    public class SetUpClass
    {
        public static IWebDriver driver = InitBrowser.Getbrowser();
        public HomePage home;
        public Read_ini read;
        public CommonCode common;
        public By cookie = By.XPath(Elements.Cookiechoice);

        private SetUpClass()
        {
            read = new Read_ini();
            home = new HomePage();
            common = new CommonCode();
        }

        [BeforeScenario]
        public void InitApplication()
        {
            driver.Navigate().GoToUrl(ReadEnv.ReadData("base", "appUrl"));
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void Aftereachscenario()

        {
            driver.SwitchTo().DefaultContent();
        }

        [AfterTestRun]
        public static void CloseApplication()
        {
            driver.Quit();
        }
    }
}