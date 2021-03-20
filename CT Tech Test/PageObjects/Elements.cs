using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_Tech_Test.PageObjects
{
    public class Elements
    {
        public static string Cookiechoice = "//a[@id='cookieChoiceDismiss']";
        public static string signupframe = "//iframe[@id='frame-one1434677811']";

        public static string firstnameinput = "RESULT_TextField-1";

        public static string lastnameinput = "RESULT_TextField-2";

        public static string phoneinput = "RESULT_TextField-3";

        public static string countryinput = "RESULT_TextField-4";

        public static string cityinput = "RESULT_TextField-5";

        public static string emailinput = "RESULT_TextField-6";
        public static string contactdropdown = "RESULT_RadioButton-9";
        public static string fileuploadaction = "//input[@type='file']";

        public static string submitbutton = "FSsubmit";
        public static string errortext = "//div[@class='form_table']/div[@class='segment_header']";
        public static string searchinput = "Wikipedia1_wikipedia-search-input";
        public static string searchicon = "//input[@class='wikipedia-search-button']";
        public static string searchoutput = "  //a[@href='https://en.wikipedia.org/wiki/SpecFlow' and contains(text(),'SpecFlow') ]";
        public static string emptyinput = "//div[text()='Please enter text to search.']";
        public static string randominput = "//div[text()='No results found.']";
    }
}