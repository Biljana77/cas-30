using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace cas_30
{
    class Selenium_tests

    {
        IWebDriver driver;
        WebDriverWait wait;

        public void Navigate(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();

        }

        [Test]
        public void TestRegistruj()
        {
            Navigate("http://shop.qa.rs");
            IWebElement buttonRegistruj = driver.FindElement(By.XPath("//a[@href='/register']"));
            if (buttonRegistruj.Displayed && buttonRegistruj.Enabled)
            {
                buttonRegistruj.Click();
            }
            IWebElement inputName = wait.Until(EC.ElementIsVisible(By.Name("ime")));
            if (inputName.Displayed && inputName.Enabled)
            {
                inputName.SendKeys("Pera");
            }
            IWebElement inputLastName = driver.FindElement(By.Name("prezime"));
            if (inputLastName.Displayed && inputLastName.Enabled)
            {
                inputLastName.SendKeys("Peric");
            }
            IWebElement inputEmail = driver.FindElement(By.Name("email"));
            if (inputEmail.Displayed && inputEmail.Enabled)
            {
                inputEmail.SendKeys("ppetar@email.com");
            }
            IWebElement inputUserName = driver.FindElement(By.Name("korisnicko"));
            if (inputUserName.Displayed && inputUserName.Enabled)
            {
                inputUserName.SendKeys("ppetar");
            }
            IWebElement inputLozinka = driver.FindElement(By.Name("lozinka"));
            if (inputLozinka.Displayed && inputLozinka.Enabled)
            {
                inputLozinka.SendKeys("pppetar");
            }
            IWebElement inputLozinkaPonovo = driver.FindElement(By.Id("passwordAgain"));
            if (inputLozinkaPonovo.Displayed && inputLozinkaPonovo.Enabled)
            {
                inputLozinkaPonovo.SendKeys("pppetar");
            }
            IWebElement buttonRegistrujse = driver.FindElement(By.Name("register"));
            if (buttonRegistrujse.Displayed && buttonRegistrujse.Enabled)
            {
                buttonRegistrujse.Click();
            }

        }
    }
}