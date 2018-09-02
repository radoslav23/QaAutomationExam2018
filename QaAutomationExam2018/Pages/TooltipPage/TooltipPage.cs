using System.Threading;
using QaAutomationExam2018.Pages;
using OpenQA.Selenium;

namespace QaAutomationExam2018.Pages.TooltipPage
{
    public partial class TooltipPage : BasePage
    {
        public TooltipPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        public void VerifyTooltipShown()
        {
            TooltipTab.Click();
            Action.MoveToElement(InpurField).Perform();
            Thread.Sleep(4000);
        }
    }
}
