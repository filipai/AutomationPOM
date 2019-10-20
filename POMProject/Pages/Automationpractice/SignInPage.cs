using NUnit.Framework;
using OpenQA.Selenium;

namespace POMProject.Pages.Automationpractice
{
    public class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver) : base(driver)
        {
        }

        public string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        private IWebElement CreateAccounyForm => Driver.FindElement(By.Id("create-account_form"));

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));

        public void AssertRegistrationPageIsOpen()
        {
            Wait.Until(d => d.FindElement(By.Id("create-account_form")));
            Assert.IsNotNull(CreateAccounyForm, "There is no create account form.");
        }
    }
}
