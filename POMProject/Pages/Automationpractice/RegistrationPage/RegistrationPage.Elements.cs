﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace POMProject.Pages.Automationpractice.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";

        public IWebElement RadioButtons => Wait.Until(d => d.FindElement(By.XPath("//*[@id='id_gender1']")));

        public IWebElement CustomerFirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement CustomerLastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public SelectElement Days
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("days"));
                return new SelectElement(reminder);
            }
        }

        public SelectElement Months
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("months"));
                return new SelectElement(reminder);
            }
        }

        public SelectElement Years
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("years"));
                return new SelectElement(reminder);
            }
        }

        public IWebElement FirstName => Driver.FindElement(By.Id("firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("lastname"));

        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public SelectElement State
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(reminder);
            }
        }

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement Phone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement Alias => Driver.FindElement(By.Id("alias"));

        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));
        public IWebElement ErrorMsg => Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol/li"));
    }
}
