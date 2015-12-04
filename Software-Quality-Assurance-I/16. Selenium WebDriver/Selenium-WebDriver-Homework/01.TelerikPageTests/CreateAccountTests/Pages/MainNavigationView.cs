using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccountTests.Pages
{
    public class MainNavigationView
    {
        public MainNavigationView(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "hlYourAccount")]
        public IWebElement YourAccount { get; set; }
    }
}
