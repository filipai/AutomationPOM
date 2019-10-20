using NUnit.Framework;
using OpenQA.Selenium;

namespace POMProject.Pages.Automationpractice
{
    public class MyAccountPage : BasePage
    {
        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement WelcomeTextElement => Driver.FindElement(By.XPath("//*[@id='center_column']/p"));

        public void AssertUserIsRegistered()
        {
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", WelcomeTextElement.Text);
        }
    }
}
