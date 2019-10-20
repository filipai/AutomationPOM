
using NUnit.Framework;
using OpenQA.Selenium;

namespace POMProject.Pages.SoftUni
{
    public class SoftUni : BasePage
    {
        public SoftUni(IWebDriver driver) : base(driver)
        {
        }

        public string Url => " http://www.softuni.bg";

        private IWebElement Trainings => Driver.FindElement(By.XPath("//*[@id='header-nav']/div[1]/ul/li[2]/a/span"));
        private IWebElement AutomationCourse => Driver.FindElement(By.XPath("//*[contains(text(),'QA Automation - септември 2019')]"));
        private IWebElement Heading => Driver.FindElement(By.XPath("/html/body/div[2]/header/h1"));

        public void NavigateToAutomationCoursePage()
        {
            Trainings.Click();
            AutomationCourse.Click();
        }

        public void AssertHeading(string text)
        {
            Assert.AreEqual(text, Heading.Text, "Text is doesn't match");
        }
    }
}
