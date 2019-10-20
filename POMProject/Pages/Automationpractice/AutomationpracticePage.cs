
using OpenQA.Selenium;

namespace POMProject.Pages.Automationpractice
{
    public class AutomationpracticePage : BasePage
    {
        public AutomationpracticePage(IWebDriver driver) : base(driver)
        {
        }

        public string Url => "http://automationpractice.com/index.php";

        private IWebElement SignIn => Driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));

        public void GoToSignInPage()
        {
            SignIn.Click();
        }
    }
}
