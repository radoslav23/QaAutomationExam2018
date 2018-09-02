using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace QaAutomationExam2018.Pages
{
    public class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private Actions action;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            action = new Actions(driver);
        }

        public IWebDriver Driver => driver;

        public WebDriverWait Wait => wait;

        public Actions Action => action;
    }
}
