using NUnit.Framework;
using OpenQA.Selenium;

namespace POMProject.Pages.SeleniumHQ
{
    class SeleniumHQ : BasePage
    {
        public SeleniumHQ(IWebDriver driver) : base(driver)
        {
        }

        private string Title => Driver.Title;
        public void AssertTitle(string text)
        {
            Assert.AreEqual(text, Title, "Title of the page doesn't match");
        }
    }
}
