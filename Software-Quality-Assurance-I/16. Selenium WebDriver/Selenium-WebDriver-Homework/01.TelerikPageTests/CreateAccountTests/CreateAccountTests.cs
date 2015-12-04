using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using CreateAccountTests.Pages;
using CreateAccountTests.Utilities;

namespace CreateAccountTests
{
    [TestClass]
    public class CreateAccountTests
    {
        private IWebDriver driver;
        private MainNavigationView mainNavigationView;
        private CreateAccountPage createAccountPage;

        [TestInitialize]
        public void TestInit()
        {
            driver = new FirefoxDriver();
            mainNavigationView = new MainNavigationView(this.driver);
            createAccountPage = new CreateAccountPage(this.driver, mainNavigationView);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void CreateAccountWithEmptyCompany()
        {
            createAccountPage.Navigate();
            createAccountPage.CreateAccount("QATrack@telerik.com", "Asya", "Georgieva", string.Empty);
            Assert.AreEqual("Company name is required", createAccountPage.CompanyRequired.Text);
        }

        [TestMethod]
        public void CreateAccountWithRandomCompany()
        {
            createAccountPage.Navigate();
            string randomCompany = RandomGenerator.GetRandomString(3, 30);
            createAccountPage.CreateAccount("QATrack@telerik.com", "Asya", "Georgieva", randomCompany);
            Assert.AreNotEqual("Company name is required", createAccountPage.CompanyRequired.Text);
        }
    }
}
