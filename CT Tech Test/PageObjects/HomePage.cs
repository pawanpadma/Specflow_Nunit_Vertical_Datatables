using CT_Tech_Test.Commons;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CT_Tech_Test.PageObjects
{
    public class HomePage
    {
        public IWebDriver driver = InitBrowser.Getbrowser();
        public CommonCode common;

        public Read_ini read;

        public By Frame2 = By.XPath(Elements.signupframe);
        public By firstname = By.Id(Elements.firstnameinput);
        public By lastname = By.Id(Elements.lastnameinput);
        public By Phonenumber = By.Id(Elements.phoneinput);
        public By Country = By.Id(Elements.countryinput);
        public By City1 = By.Id(Elements.cityinput);
        public By Email = By.Id(Elements.emailinput);

        public By Contact = By.Id(Elements.contactdropdown);
        public By FileUpload = By.XPath(Elements.fileuploadaction);
        public By Submitform1 = By.Id(Elements.submitbutton);
        public By errorMessage = By.XPath(Elements.errortext);

        public HomePage()
        {
            common = new CommonCode();
            read = new Read_ini();
        }

        public void homepagetitle()
        {
            Assert.AreEqual(read.GetProperty("homePage", "homeTitle"), driver.Title);
        }

        public Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }

        public void EnterFormDetails(Table table)
        {
            driver.SwitchTo().Frame(driver.FindElement(Frame2));

            foreach (var row in table.Rows)
            {
                switch (row[0])
                {
                    case "firstname":
                        common.ElementExists(firstname, 5);
                        driver.FindElement(firstname).SendKeys(row[1]);
                        break;

                    case "lastname":
                        common.ElementExists(lastname, 5);
                        driver.FindElement(lastname).SendKeys(row[1]);
                        break;

                    case "phone":
                        common.ElementExists(Phonenumber, 5);
                        driver.FindElement(Phonenumber).SendKeys(row[1]);
                        break;

                    case "Country":
                        common.ElementExists(Country, 5);
                        driver.FindElement(Country).SendKeys(row[1]);
                        break;

                    case "City":
                        common.ElementExists(City1, 5);
                        driver.FindElement(City1).SendKeys(row[1]);
                        break;

                    case "EmailAddress":
                        common.ElementExists(Email, 5);
                        driver.FindElement(Email).SendKeys(row[1]);
                        break;

                    case "Gender":
                        driver.FindElement(By.XPath("//table[@class='inline_grid choices']//label[contains(@for,'RESULT_RadioButton') and text()='" + row[1] + "']")).Click();
                        break;

                    case "Week":

                        driver.FindElement(By.XPath("//label[contains(@for,'RESULT_CheckBox') and text()='" + row[1] + "']")).Click();
                        break;

                    case "ContactTime":
                        SelectElement s = new SelectElement(driver.FindElement(Contact));
                        s.SelectByText(row[1]);
                        break;
                }
            }
        }

        public void Submitform()
        {
            common.ElementToBeClickable(Submitform1, 5).Click();
        }

        public string ValidateError()
        {
            common.ElementIsVisible(errorMessage, 5);
            return driver.FindElement(errorMessage).Text;
        }

        public void Fileuploadonform()
        {
            driver.SwitchTo().Frame(driver.FindElement(Frame2));
            common.ElementExists(FileUpload, 3);
            driver.FindElement(FileUpload).SendKeys(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"resources\trial.txt"));
        }
    }
}