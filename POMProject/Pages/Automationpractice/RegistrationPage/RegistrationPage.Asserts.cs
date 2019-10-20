using NUnit.Framework;

namespace POMProject.Pages.Automationpractice.RegistrationPage
{
    public partial class RegistrationPage
    {
        public void AssertInvalidZIPRegistration()
        {
            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", ErrorMsg.Text);
        }
    }
}
