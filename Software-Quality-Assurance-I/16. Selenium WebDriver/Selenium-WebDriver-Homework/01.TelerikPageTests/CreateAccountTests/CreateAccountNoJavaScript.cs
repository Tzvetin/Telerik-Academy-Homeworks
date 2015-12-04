using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using CreateAccountTests.Pages;
using CreateAccountTests.Utilities;
using OpenQA.Selenium.Remote;

namespace CreateAccountTests
{
    [TestClass]
    public class CreateAccountNoJavaScript
    {
        private IWebDriver driver;
        private MainNavigationView mainNavigationView;
        private CreateAccountPage createAccountPage;
        private FirefoxProfile profile;

        [TestInitialize]
        public void TestInit()
        {
            profile = new FirefoxProfile();
            profile.SetPreference("javascript.enabled", false);
            driver = new FirefoxDriver(profile);
            mainNavigationView = new MainNavigationView(this.driver);
            createAccountPage = new CreateAccountPage(this.driver, mainNavigationView);
            /*
            DesiredCapabilities dc = DesiredCapabilities.firefox();
            dc.setCapability(CapabilityType.SUPPORTS_JAVASCRIPT, false);
            RemoteWebDriver rwd = new RemoteWebDriver(URL, dc);
             * */
        }

        [TestCleanup]
        public void TestCleanup()
        {
            profile.SetPreference("javascript.enabled", true);
            //driver.Quit();
        }
                
        [TestMethod]
        public void CreateAccountWithRandomCompanyNoJavaScript()
        {
            createAccountPage.Navigate();
            string randomCompany = RandomGenerator.GetRandomString(3, 30);
            createAccountPage.CreateAccount("QATrack@telerik.com", "Asya", "Georgieva", randomCompany);
            Assert.AreNotEqual("Company name is required", createAccountPage.CompanyRequired.Text);
        }
    }
}
