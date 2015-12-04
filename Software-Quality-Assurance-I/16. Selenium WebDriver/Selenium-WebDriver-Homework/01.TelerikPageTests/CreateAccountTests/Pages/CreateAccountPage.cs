using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccountTests.Pages
{
    public class CreateAccountPage
    {
        private readonly IWebDriver driver;
        private readonly MainNavigationView mainNavigationView;

        public CreateAccountPage(IWebDriver driver, MainNavigationView mainNavigationView)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
            this.mainNavigationView = mainNavigationView;
        }

        [FindsBy(How = How.XPath, Using = "//html/body/form/div[3]/div/div/div/div/div[1]/div/div[2]/div/div[4]/div/a")]
        public IWebElement RegisterLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'tbEmail')]")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'tbFirstName')]")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'tbLastName')]")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'tbCompanyName')]")]
        public IWebElement Company { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'rfvCompanyName')]")]
        public IWebElement CompanyRequired { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'btnSubmit')]")]
        public IWebElement CreateAccountButton { get; set; }
        
        public void Navigate()
        {
            driver.Url = "https://www.telerik.com/";
            mainNavigationView.YourAccount.Click();
            RegisterLink.Click();
        }

        public void CreateAccount(string email, string firstName, string lastName, string company)
        {
            this.Email.SendKeys(email);
            this.FirstName.SendKeys(firstName);
            this.LastName.SendKeys(lastName);
            this.Company.SendKeys(company);
            this.CreateAccountButton.Click();
        }
    }
}
