using OpenQA.Selenium;

namespace QaAutomationExam2018.Pages.TooltipPage
{
    public partial class TooltipPage
    {
        public IWebElement TooltipTab => Driver.FindElement(By.Id("menu-item-99"));

        public IWebElement InpurField => Driver.FindElement(By.Id("age"));

        public IWebElement HoverField => Driver.FindElement(By.XPath("//div[5]/div[1]"));
    }
}
