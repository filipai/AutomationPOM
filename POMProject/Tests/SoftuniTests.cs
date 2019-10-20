using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using POMProject.Pages.SoftUni;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace POMProject.Tests
{
    [TestFixture]
    class SoftuniTests
    {
        private ChromeDriver _driver;
        private SoftUni _softUni;

        [SetUp]
        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();

            _softUni = new SoftUni(_driver);
        }

        [Test]
        public void AutomationCourseHeading()
        {
            _softUni.Navigate(_softUni.Url);
            _softUni.NavigateToAutomationCoursePage();
            _softUni.AssertHeading("QA Automation - септември 2019");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
