using CT_Tech_Test.Commons;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_Tech_Test.PageObjects
{
    public class NewWindows
    {
        public IWebDriver driver = InitBrowser.Getbrowser();
        public CommonCode common;
        public Read_ini read;
        public By Searchinputbox = By.Id(Elements.searchinput);
        public By Searchbutton = By.XPath(Elements.searchicon);
        public By Result = By.XPath(Elements.searchoutput);
        public By Emptytfield = By.XPath(Elements.emptyinput);
        public By Randomfield = By.XPath(Elements.randominput);

        public NewWindows()
        {
            common = new CommonCode();
            read = new Read_ini();
        }

        public void NewWinsearch(string stext)
        {
            driver.FindElement(Searchinputbox).SendKeys(stext);
        }

        public void Clicksearch()
        {
            driver.FindElement(Searchbutton).Click();
        }

        public bool Searchresult(string text)
        {
            IWebElement ele = common.ElementExists(By.XPath("//div[@class='wikipedia-search-main-container']//*[text()='" + text + "']"), 3);
            bool a = ele.Displayed;
            return a;
        }
    }
}