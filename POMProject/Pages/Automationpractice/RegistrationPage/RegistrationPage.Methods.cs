using POMProject.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace POMProject.Pages.Automationpractice.RegistrationPage
{
    public partial class RegistrationPage
    {

        public void FillForm(RegistrationUser user)
        {
            RadioButtons.Click();
            CustomerFirstName.SendKeys(user.FirstName);
            CustomerLastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Days.SelectByValue(user.Date);
            Months.SelectByValue(user.Month);
            Years.SelectByValue(user.Year);
            FirstName.SendKeys(user.RealFirstName);
            LastName.SendKeys(user.RealLastName);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByValue(user.State);
            PostCode.SendKeys(user.PostCode);
            Phone.SendKeys(user.Phone);
            Alias.SendKeys(user.Alias);
            RegisterButton.Click();
        }

        public void Navigate(SignInPage SignUpPage)
        {
            SignUpPage.Navigate("http://automationpractice.com/index.php?controller=my-account");

            SignUpPage.Email.SendKeys($"test{Guid.NewGuid().ToString().Substring(0, 7)}@gmail.com");
            SignUpPage.Submit.Click();
        }
    }
}
