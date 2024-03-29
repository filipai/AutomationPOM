﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using POMProject.Common;
using POMProject.Pages.Automationpractice;
using POMProject.Pages.Automationpractice.RegistrationPage;
using POMProject.Users;
using System.IO;
using System.Reflection;

namespace POMProject.Tests
{
    [TestFixture]
    class AutomationpracticeTests
    {
        private ChromeDriver _driver;
        private AutomationpracticePage _automationpracticePage;
        private SignInPage _signInPage;
        private RegistrationPage _regPage;
        private RegistrationUser _user;
        private MyAccountPage _myAccount;

        [SetUp]
        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();

            _automationpracticePage = new AutomationpracticePage(_driver);
            _signInPage = new SignInPage(_driver);
            _regPage = new RegistrationPage(_driver);
            _myAccount = new MyAccountPage(_driver);
        }

        [Test]
        public void AutomationpracticeRegistrationPage()
        {
            _automationpracticePage.Navigate(_automationpracticePage.Url);
            _automationpracticePage.GoToSignInPage();
            _signInPage.AssertRegistrationPageIsOpen();
        }

        [Test]
        public void ValidRegistration()
        {
            _user = UserFactory.CreateValidUser();
            _regPage.Navigate(_signInPage);
            _regPage.FillForm(_user);
            _myAccount.AssertUserIsRegistered();
        }

        [Test]
        public void InvalidZipCodeRegistration()
        {
            _user = UserFactory.CreateInvalidZipUser();
            _regPage.Navigate(_signInPage);
            _regPage.FillForm(_user);
            _regPage.AssertInvalidZIPRegistration();
        }

        [Test]
        public void InvalidFirstNameRegistration()
        {
            _user = UserFactory.CreateInvalidFirstnameUser();
            _regPage.Navigate(_signInPage);
            _regPage.FillForm(_user);
            _regPage.AssertInvalidFirstNameRegistration();
        }

        [Test]
        public void InvalidLastNameRegistration()
        {
            _user = UserFactory.CreateInvalidLastNameUser();
            _regPage.Navigate(_signInPage);
            _regPage.FillForm(_user);
            _regPage.AssertInvalidLastNameRegistration();
        }

        [Test]
        public void InvalidPasswordRegistration()
        {
            _user = UserFactory.CreateInvalidPasswordUser();
            _regPage.Navigate(_signInPage);
            _regPage.FillForm(_user);
            _regPage.AssertInvalidPasswordRegistration();
        }

        [Test]
        public void InvalidCityRegistration()
        {
            _user = UserFactory.CreateInvalidCityUser();
            _regPage.Navigate(_signInPage);
            _regPage.FillForm(_user);
            _regPage.AssertInvalidCityRegistration();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
