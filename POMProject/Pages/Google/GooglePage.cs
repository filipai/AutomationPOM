using OpenQA.Selenium;

namespace POMProject.Pages.Google
{
    public class GooglePage : BasePage
    {
        public GooglePage(IWebDriver driver) : base(driver)
        {
        }

        public string Url => "https://www.google.com";

        private IWebElement InputField => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));
        private IWebElement SearchBtn => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]"));
        private IWebElement FirstResult => Driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div[1]/a[1]"));

        public void Search(string text)
        {
            InputField.SendKeys(text);
            InputField.Submit();
        }

        public void OpenFirstResult()
        {
            FirstResult.Click();
        }
    }
}
