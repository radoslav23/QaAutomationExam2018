using System.Threading;
using OpenQA.Selenium;

namespace QaAutomationExam2018.Pages.BlogPage
{
    public partial class BlogPage : BasePage
    {
        public BlogPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl("https://www.automatetheplanet.com/");
        }

        public void GoToBlog()
        {
            BlogLink.Click();
            WebDriverTestsFirefoxLink.Click();
            Thread.Sleep(3000);
        }

        public void ScrollDown()
        {
            Action.MoveToElement(QuickNavigation).Perform();
        }

        public void ClickFirstLink()
        {
            TestCaseLink.Click();
        }

        public void ClickSecondLink()
        {
            HeadlessExecutionFirefoxDriverLink.Click();
        }

        public void ClickThirdLink()
        {
            BenchmarkAgainstOtherBrowsersLink.Click();
        }

        public void ClickFourthLink()
        {
            TestCaseCodeLink.Click();
        }

        public void ClickFifthLink()
        {
            BenchmarkExecutionTimeLink.Click();
        }

        public void ClickSixthLink()
        {
            BenchmarkTestsLink.Click();
        }

        public void ClickSeventhLink()
        {
            BenchmarkResultsLink.Click();
        }
    }
}
