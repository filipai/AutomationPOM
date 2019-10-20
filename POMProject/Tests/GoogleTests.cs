using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using POMProject.Pages.Google;
using POMProject.Pages.SeleniumHQ;
using System.IO;
using System.Reflection;

namespace POMProject.Tests
{
    [TestFixture]
    public class GoogleTests
    {
        private ChromeDriver _driver;
        private GooglePage _googlePage;
        private SeleniumHQ _seleniumhq;

        [SetUp]
        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();

            _googlePage = new GooglePage(_driver);
            _seleniumhq = new SeleniumHQ(_driver);
        }

        [Test]
        public void SearchSelenium()
        {
            _googlePage.Navigate(_googlePage.Url);
            _googlePage.Search("Selenium");
            _googlePage.OpenFirstResult();
            _seleniumhq.AssertTitle("Selenium - Web Browser Automation");         
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
