using NUnit.Framework;

namespace POMProject.Pages.Automationpractice.RegistrationPage
{
    public partial class RegistrationPage
    {
        public void AssertInvalidZIPRegistration()
        {
            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", ErrorMsg.Text);
        }

        public void AssertInvalidFirstNameRegistration()
        {
            Assert.AreEqual("firstname is required.", ErrorMsg.Text);
        }

        public void AssertInvalidLastNameRegistration()
        {
            Assert.AreEqual("lastname is required.", ErrorMsg.Text);
        }

        public void AssertInvalidPasswordRegistration()
        {
            Assert.AreEqual("passwd is required.", ErrorMsg.Text);
        }

        public void AssertInvalidCityRegistration()
        {
            Assert.AreEqual("city is required.", ErrorMsg.Text);
        }
    }
}
